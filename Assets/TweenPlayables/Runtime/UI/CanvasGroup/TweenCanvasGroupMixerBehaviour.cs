using UnityEngine;

namespace TweenPlayables
{
    public sealed class TweenCanvasGroupMixerBehaviour : TweenAnimationMixerBehaviour<CanvasGroup, TweenCanvasGroupBehaviour>
    {
        readonly FloatValueMixer alphaMixer = new();

        public override void Blend(CanvasGroup binding, TweenCanvasGroupBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.Alpha.IsActive)
            {
                alphaMixer.Blend(behaviour.Alpha.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(CanvasGroup binding)
        {
            if (alphaMixer.HasValue)
            {
                binding.alpha = alphaMixer.Value;
            }

            alphaMixer.Clear();
        }
    }
}