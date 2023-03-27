using UnityEngine.UI;

namespace AnnulusGames.TweenPlayables
{
    public class TweenSliderMixerBehaviour : TweenAnimationMixerBehaviour<Slider, TweenSliderBehaviour>
    {
        private FloatValueMixer valueMixer = new FloatValueMixer();

        public override void Blend(TweenSliderBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.value.active)
            {
                valueMixer.Blend(behaviour.value.Evaluate(progress), weight);
            }
        }

        public override void Apply(Slider binding)
        {
            if (valueMixer.ValueCount > 0)
            {
                binding.value = valueMixer.Value;
            }

            valueMixer.Clear();
        }
    }

}