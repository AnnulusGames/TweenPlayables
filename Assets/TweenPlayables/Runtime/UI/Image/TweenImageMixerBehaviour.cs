using UnityEngine.UI;

namespace TweenPlayables
{
    public sealed class TweenImageMixerBehaviour : TweenAnimationMixerBehaviour<Image, TweenImageBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();
        readonly FloatValueMixer fillAmountMixer = new();

        public override void Blend(Image binding, TweenImageBehaviour behaviour, float weight, float progress)
        {
            colorMixer.TryBlend(behaviour.Color, binding, progress, weight);
            fillAmountMixer.TryBlend(behaviour.FillAmount, binding, progress, weight);
        }

        public override void Apply(Image binding)
        {
            colorMixer.TryApplyAndClear(binding, (x, binding) => binding.color = x);
            fillAmountMixer.TryApplyAndClear(binding, (x, binding) => binding.fillAmount = x);
        }
    }
}