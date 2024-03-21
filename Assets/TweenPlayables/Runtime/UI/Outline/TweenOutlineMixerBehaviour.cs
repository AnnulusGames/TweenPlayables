using UnityEngine.UI;

namespace TweenPlayables
{
    public sealed class TweenOutlineMixerBehaviour : TweenAnimationMixerBehaviour<Outline, TweenOutlineBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();
        readonly Vector2ValueMixer distanceMixer = new();

        public override void Blend(Outline binding, TweenOutlineBehaviour behaviour, float weight, float progress)
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

        public override void Apply(Outline binding)
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