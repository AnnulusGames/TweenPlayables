using UnityEngine.UI;

namespace TweenPlayables
{
    public sealed class TweenSliderMixerBehaviour : TweenAnimationMixerBehaviour<Slider, TweenSliderBehaviour>
    {
        readonly FloatValueMixer valueMixer = new();

        public override void Blend(Slider binding, TweenSliderBehaviour behaviour, float weight, float progress)
        {
            valueMixer.TryBlend(behaviour.Value, binding, progress, weight);
        }

        public override void Apply(Slider binding)
        {
            valueMixer.TryApplyAndClear(binding, (x, binding) => binding.value = x);
        }
    }
}