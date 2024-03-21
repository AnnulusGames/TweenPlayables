using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace TweenPlayables
{
    public sealed class TweenRendererMixerBehaviour : TweenAnimationMixerBehaviour<Renderer, TweenRendererBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();
        readonly Vector2ValueMixer textureOffsetMixer = new();
        readonly Vector2ValueMixer textureScaleMixer = new();

        readonly Dictionary<object, Material> materialDictionary = new();

        public override void OnPlayableDestroy(Playable playable)
        {
            foreach (Material m in materialDictionary.Values)
            {
                Object.DestroyImmediate(m);
            }
            materialDictionary.Clear();
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            var renderer = playerData as Renderer;
            if (renderer != null)
            {
                if (!materialDictionary.ContainsKey(playerData))
                {
                    var material = new Material(renderer.sharedMaterial);
                    renderer.material = material;
                    materialDictionary.Add(playerData, material);
                }
            }

            base.ProcessFrame(playable, info, playerData);
        }

        public override void Blend(Renderer binding, TweenRendererBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.Color.IsActive)
            {
                colorMixer.Blend(behaviour.Color.Evaluate(binding, progress), weight);
            }
            if (behaviour.TextureOffset.IsActive)
            {
                textureOffsetMixer.Blend(behaviour.TextureOffset.Evaluate(binding, progress), weight);
            }
            if (behaviour.TextureScale.IsActive)
            {
                textureScaleMixer.Blend(behaviour.TextureScale.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Renderer binding)
        {
            if (colorMixer.HasValue)
            {
                materialDictionary[binding].color = colorMixer.Value;
            }
            if (textureOffsetMixer.HasValue)
            {
                materialDictionary[binding].mainTextureOffset = textureOffsetMixer.Value;
            }
            if (textureScaleMixer.HasValue)
            {
                materialDictionary[binding].mainTextureScale = textureScaleMixer.Value;
            }

            colorMixer.Clear();
            textureOffsetMixer.Clear();
            textureScaleMixer.Clear();
        }
    }
}