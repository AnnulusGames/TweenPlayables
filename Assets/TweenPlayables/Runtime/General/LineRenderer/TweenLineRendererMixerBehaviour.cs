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
            startColorMixer.TryBlend(behaviour.StartColor, binding, progress, weight);
            endColorMixer.TryBlend(behaviour.EndColor, binding, progress, weight);
            startWidthMixer.TryBlend(behaviour.StartWidth, binding, progress, weight);
            endWidthMixer.TryBlend(behaviour.EndWidth, binding, progress, weight);
        }

        public override void Apply(LineRenderer binding)
        {
            startColorMixer.TryApplyAndClear(binding, (x, binding) => binding.startColor = x);
            endColorMixer.TryApplyAndClear(binding, (x, binding) => binding.endColor = x);
            startWidthMixer.TryApplyAndClear(binding, (x, binding) => binding.startWidth = x);
            endWidthMixer.TryApplyAndClear(binding, (x, binding) => binding.endWidth = x);
        }
    }
}