using UnityEngine.UI;

namespace TweenPlayables
{
    public sealed class TweenSliderMixerBehaviour : TweenAnimationMixerBehaviour<Slider, TweenSliderBehaviour>
    {
        readonly FloatValueMixer valueMixer = new();

        public override void Blend(Slider binding, TweenSliderBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.Value.IsActive)
            {
                valueMixer.Blend(behaviour.Value.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Slider binding)
        {
            if (valueMixer.HasValue)
            {
                binding.value = valueMixer.Value;
            }

            valueMixer.Clear();
        }
    }
}