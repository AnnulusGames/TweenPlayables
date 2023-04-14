using UnityEngine.UI;

namespace AnnulusGames.TweenPlayables
{
    public class TweenOutlineMixerBehaviour : TweenAnimationMixerBehaviour<Outline, TweenOutlineBehaviour>
    {
        private ColorValueMixer colorMixer = new ColorValueMixer();
        private Vector2ValueMixer distanceMixer = new Vector2ValueMixer();

        public override void Blend(Outline binding, TweenOutlineBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.color.active)
            {
                colorMixer.Blend(behaviour.color.Evaluate(binding, progress), weight);
            }
            if (behaviour.distance.active)
            {
                distanceMixer.Blend(behaviour.distance.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Outline binding)
        {
            if (colorMixer.ValueCount > 0)
            {
                binding.effectColor = colorMixer.Value;
            }
            if (distanceMixer.ValueCount > 0)
            {
                binding.effectDistance = distanceMixer.Value;
            }

            colorMixer.Clear();
            distanceMixer.Clear();
        }
    }

}