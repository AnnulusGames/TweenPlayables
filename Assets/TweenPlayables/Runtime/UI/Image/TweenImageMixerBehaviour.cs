using UnityEngine.UI;

namespace TweenPlayables
{
    public sealed class TweenImageMixerBehaviour : TweenAnimationMixerBehaviour<Image, TweenImageBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();
        readonly FloatValueMixer fillAmountMixer = new();

        public override void Blend(Image binding, TweenImageBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.Color.IsActive)
            {
                colorMixer.Blend(behaviour.Color.Evaluate(binding, progress), weight);
            }
            if (behaviour.FillAmount.IsActive)
            {
                fillAmountMixer.Blend(behaviour.FillAmount.Evaluate(binding, progress), weight);
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