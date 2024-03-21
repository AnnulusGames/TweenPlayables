using UnityEngine.UI;

namespace TweenPlayables
{
    public class TweenShadowMixerBehaviour : TweenAnimationMixerBehaviour<Shadow, TweenShadowBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();
        readonly Vector2ValueMixer distanceMixer = new();

        public override void Blend(Shadow binding, TweenShadowBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.Color.IsActive)
            {
                colorMixer.Blend(behaviour.Color.Evaluate(binding, progress), weight);
            }
            if (behaviour.Distance.IsActive)
            {
                distanceMixer.Blend(behaviour.Distance.Evaluate(binding, progress), weight);
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