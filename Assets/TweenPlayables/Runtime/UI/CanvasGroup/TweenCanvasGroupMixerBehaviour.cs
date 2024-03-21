using UnityEngine;

namespace TweenPlayables
{
    public sealed class TweenCanvasGroupMixerBehaviour : TweenAnimationMixerBehaviour<CanvasGroup, TweenCanvasGroupBehaviour>
    {
        readonly FloatValueMixer alphaMixer = new();

        public override void Blend(CanvasGroup binding, TweenCanvasGroupBehaviour behaviour, float weight, float progress)
        {
            alphaMixer.TryBlend(behaviour.Alpha, binding, progress, weight);
        }

        public override void Apply(CanvasGroup binding)
        {
            alphaMixer.TryApplyAndClear(binding, (x, binding) => binding.alpha = x);
        }
    }
}