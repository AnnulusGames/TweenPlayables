using UnityEngine.UI;

namespace AnnulusGames.TweenPlayables
{
    public class TweenGraphicMixerBehaviour : TweenAnimationMixerBehaviour<Graphic, TweenGraphicBehaviour>
    {
        private ColorValueMixer colorMixer = new ColorValueMixer();

        public override void Blend(Graphic binding, TweenGraphicBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.color.active)
            {
                colorMixer.Blend(behaviour.color.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Graphic binding)
        {
            if (colorMixer.ValueCount > 0)
            {
                binding.color = colorMixer.Value;
            }

            colorMixer.Clear();
        }
    }

}