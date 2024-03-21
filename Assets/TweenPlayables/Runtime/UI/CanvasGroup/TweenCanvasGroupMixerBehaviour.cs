using UnityEngine;

namespace TweenPlayables
{
    public class TweenCanvasGroupMixerBehaviour : TweenAnimationMixerBehaviour<CanvasGroup, TweenCanvasGroupBehaviour>
    {
        private FloatValueMixer alphaMixer = new();

        public override void Blend(CanvasGroup binding, TweenCanvasGroupBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.alpha.IsActive)
            {
                alphaMixer.Blend(behaviour.alpha.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(CanvasGroup binding)
        {
            if (alphaMixer.ValueCount > 0)
            {
                binding.alpha = alphaMixer.Value;
            }

            alphaMixer.Clear();
        }
    }

}