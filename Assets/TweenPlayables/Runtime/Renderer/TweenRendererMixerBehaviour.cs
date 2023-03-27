using UnityEngine;
using UnityEngine.Playables;

namespace AnnulusGames.TweenPlayables
{
    public class TweenRendererMixerBehaviour : TweenAnimationMixerBehaviour<Renderer, TweenRendererBehaviour>
    {
        private ColorValueMixer colorMixer = new ColorValueMixer();
        private Vector2ValueMixer textureOffsetMixer = new Vector2ValueMixer();
        private Vector2ValueMixer textureScaleMixer = new Vector2ValueMixer();

        private Material material = null;

        public override void OnPlayableDestroy(Playable playable)
        {
            if (material != null) Object.DestroyImmediate(material);
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            var renderer = playerData as Renderer;
            if (renderer != null)
            {
                if (!material)
                {
                    material = new Material(renderer.sharedMaterial);
                    renderer.material = material;
                }
            }

            base.ProcessFrame(playable, info, playerData);
        }

        public override void Blend(TweenRendererBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.color.active)
            {
                colorMixer.Blend(behaviour.color.Evaluate(progress), weight);
            }
            if (behaviour.textureOffset.active)
            {
                textureOffsetMixer.Blend(behaviour.textureOffset.Evaluate(progress), weight);
            }
            if (behaviour.textureScale.active)
            {
                textureScaleMixer.Blend(behaviour.textureScale.Evaluate(progress), weight);
            }
        }

        public override void Apply(Renderer binding)
        {
            if (colorMixer.ValueCount > 0)
            {
                material.color = colorMixer.Value;
            }
            if (textureOffsetMixer.ValueCount > 0)
            {
                material.mainTextureOffset = textureOffsetMixer.Value;
            }
            if (textureScaleMixer.ValueCount > 0)
            {
                material.mainTextureScale = textureScaleMixer.Value;
            }

            colorMixer.Clear();
            textureOffsetMixer.Clear();
            textureScaleMixer.Clear();
        }
    }

}