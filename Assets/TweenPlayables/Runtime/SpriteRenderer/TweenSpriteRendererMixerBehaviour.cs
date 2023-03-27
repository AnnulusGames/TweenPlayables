using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    public class TweenSpriteRendererMixerBehaviour : TweenAnimationMixerBehaviour<SpriteRenderer, TweenSpriteRendererBehaviour>
    {
        private ColorValueMixer colorMixer = new ColorValueMixer();

        public override void Blend(TweenSpriteRendererBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.color.active)
            {
                colorMixer.Blend(behaviour.color.Evaluate(progress), weight);
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