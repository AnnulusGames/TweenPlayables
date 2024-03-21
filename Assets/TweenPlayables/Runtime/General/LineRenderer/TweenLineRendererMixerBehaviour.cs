using UnityEngine;

namespace TweenPlayables
{
    public sealed class TweenLineRendererMixerBehaviour : TweenAnimationMixerBehaviour<LineRenderer, TweenLineRendererBehaviour>
    {
        readonly ColorValueMixer startColorMixer = new();
        readonly ColorValueMixer endColorMixer = new();
        readonly FloatValueMixer startWidthMixer = new();
        readonly FloatValueMixer endWidthMixer = new();

        public override void Blend(LineRenderer binding, TweenLineRendererBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.StartColor.IsActive)
            {
                startColorMixer.Blend(behaviour.StartColor.Evaluate(binding, progress), weight);
            }
            if (behaviour.EndColor.IsActive)
            {
                endColorMixer.Blend(behaviour.EndColor.Evaluate(binding, progress), weight);
            }
            if (behaviour.StartWidth.IsActive)
            {
                startWidthMixer.Blend(behaviour.StartWidth.Evaluate(binding, progress), weight);
            }
            if (behaviour.EndWidth.IsActive)
            {
                endWidthMixer.Blend(behaviour.EndWidth.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(LineRenderer binding)
        {
            if (startColorMixer.HasValue)
            {
                binding.startColor = startColorMixer.Value;
            }
            if (endColorMixer.HasValue)
            {
                binding.endColor = endColorMixer.Value;
            }
            if (startWidthMixer.HasValue)
            {
                binding.startWidth = startWidthMixer.Value;
            }
            if (endWidthMixer.HasValue)
            {
                binding.endWidth = endWidthMixer.Value;
            }

            startColorMixer.Clear();
            endColorMixer.Clear();
            startWidthMixer.Clear();
            endWidthMixer.Clear();
        }
    }

}