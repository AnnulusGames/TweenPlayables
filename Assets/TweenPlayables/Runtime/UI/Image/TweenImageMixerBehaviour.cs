using UnityEngine.UI;

namespace TweenPlayables
{
    public class TweenImageMixerBehaviour : TweenAnimationMixerBehaviour<Image, TweenImageBehaviour>
    {
        private ColorValueMixer colorMixer = new();
        private FloatValueMixer fillAmountMixer = new();

        public override void Blend(Image binding, TweenImageBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.color.IsActive)
            {
                colorMixer.Blend(behaviour.color.Evaluate(binding, progress), weight);
            }
            if (behaviour.fillAmount.IsActive)
            {
                fillAmountMixer.Blend(behaviour.fillAmount.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Image binding)
        {
            if (colorMixer.HasValue)
            {
                binding.color = colorMixer.Value;
            }
            if (fillAmountMixer.HasValue)
            {
                binding.fillAmount = fillAmountMixer.Value;
            }

            colorMixer.Clear();
            fillAmountMixer.Clear();
        }
    }

}