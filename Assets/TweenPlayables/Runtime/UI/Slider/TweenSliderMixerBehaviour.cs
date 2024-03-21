using UnityEngine.UI;

namespace TweenPlayables
{
    public class TweenSliderMixerBehaviour : TweenAnimationMixerBehaviour<Slider, TweenSliderBehaviour>
    {
        private FloatValueMixer valueMixer = new();

        public override void Blend(Slider binding, TweenSliderBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.value.IsActive)
            {
                valueMixer.Blend(behaviour.value.Evaluate(binding, progress), weight);
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