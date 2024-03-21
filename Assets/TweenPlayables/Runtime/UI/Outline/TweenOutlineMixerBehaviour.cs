using UnityEngine.UI;

namespace TweenPlayables
{
    public sealed class TweenOutlineMixerBehaviour : TweenAnimationMixerBehaviour<Outline, TweenOutlineBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();
        readonly Vector3ValueMixer distanceMixer = new();

        public override void Blend(Outline binding, TweenOutlineBehaviour behaviour, float weight, float progress)
        {
            colorMixer.TryBlend(behaviour.Color, binding, progress, weight);
            distanceMixer.TryBlend(behaviour.Distance, binding, progress, weight);
        }

        public override void Apply(Outline binding)
        {
            colorMixer.TryApplyAndClear(binding, (x, binding) => binding.effectColor = x);
            distanceMixer.TryApplyAndClear(binding, (x, binding) => binding.effectDistance = x);
        }
    }
}