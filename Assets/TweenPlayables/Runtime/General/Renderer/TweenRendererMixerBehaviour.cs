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
            colorMixer.TryBlend(behaviour.Color, binding, progress, weight);
            textureOffsetMixer.TryBlend(behaviour.TextureOffset, binding, progress, weight);
            textureScaleMixer.TryBlend(behaviour.TextureScale, binding, progress, weight);
        }

        public override void Apply(Renderer binding)
        {
            colorMixer.TryApplyAndClear(materialDictionary[binding], (x, binding) => binding.color = x);
            textureOffsetMixer.TryApplyAndClear(materialDictionary[binding], (x, binding) => binding.mainTextureOffset = x);
            textureScaleMixer.TryApplyAndClear(materialDictionary[binding], (x, binding) => binding.mainTextureScale = x);
        }
    }
}