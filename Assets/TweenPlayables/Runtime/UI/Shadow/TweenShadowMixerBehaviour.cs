using UnityEngine.UI;

namespace TweenPlayables
{
    public class TweenShadowMixerBehaviour : TweenAnimationMixerBehaviour<Shadow, TweenShadowBehaviour>
    {
        private ColorValueMixer colorMixer = new();
        private Vector2ValueMixer distanceMixer = new();

        public override void Blend(Shadow binding, TweenShadowBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.color.IsActive)
            {
                colorMixer.Blend(behaviour.color.Evaluate(binding, progress), weight);
            }
            if (behaviour.distance.IsActive)
            {
                distanceMixer.Blend(behaviour.distance.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Shadow binding)
        {
            if (colorMixer.HasValue)
            {
                binding.effectColor = colorMixer.Value;
            }
            if (distanceMixer.HasValue)
            {
                binding.effectDistance = distanceMixer.Value;
            }

            colorMixer.Clear();
            distanceMixer.Clear();
        }
    }

}