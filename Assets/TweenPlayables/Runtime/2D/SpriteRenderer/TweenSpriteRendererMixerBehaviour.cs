using UnityEngine;

namespace TweenPlayables
{
    public class TweenSpriteRendererMixerBehaviour : TweenAnimationMixerBehaviour<SpriteRenderer, TweenSpriteRendererBehaviour>
    {
        private ColorValueMixer colorMixer = new();

        public override void Blend(SpriteRenderer binding, TweenSpriteRendererBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.color.IsActive)
            {
                colorMixer.Blend(behaviour.color.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(SpriteRenderer binding)
        {
            if (colorMixer.ValueCount > 0)
            {
                binding.color = colorMixer.Value;
            }

            colorMixer.Clear();
        }
    }

}