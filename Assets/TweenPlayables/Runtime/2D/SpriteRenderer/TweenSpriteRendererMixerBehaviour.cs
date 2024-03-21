using UnityEngine;

namespace TweenPlayables
{
    public class TweenSpriteRendererMixerBehaviour : TweenAnimationMixerBehaviour<SpriteRenderer, TweenSpriteRendererBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();

        public override void Blend(SpriteRenderer binding, TweenSpriteRendererBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.Color.IsActive)
            {
                colorMixer.Blend(behaviour.Color.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(SpriteRenderer binding)
        {
            if (colorMixer.HasValue)
            {
                binding.color = colorMixer.Value;
            }

            colorMixer.Clear();
        }
    }
}