using UnityEngine.UI;

namespace AnnulusGames.TweenPlayables
{
    public class TweenImageMixerBehaviour : TweenAnimationMixerBehaviour<Image, TweenImageBehaviour>
    {
        private ColorValueMixer colorMixer = new ColorValueMixer();
        private FloatValueMixer fillAmountMixer = new FloatValueMixer();

        public override void Blend(Image binding, TweenImageBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.color.active)
            {
                colorMixer.Blend(behaviour.color.Evaluate(binding, progress), weight);
            }
            if (behaviour.fillAmount.active)
            {
                fillAmountMixer.Blend(behaviour.fillAmount.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Image binding)
        {
            if (colorMixer.ValueCount > 0)
            {
                binding.color = colorMixer.Value;
            }
            if (fillAmountMixer.ValueCount > 0)
            {
                binding.fillAmount = fillAmountMixer.Value;
            }

            colorMixer.Clear();
            fillAmountMixer.Clear();
        }
    }

}