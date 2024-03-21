using UnityEngine;

namespace TweenPlayables
{
    public sealed class TweenTransformMixerBehaviour : TweenAnimationMixerBehaviour<Transform, TweenTransformBehaviour>
    {
        readonly Vector3ValueMixer positionMixer = new();
        readonly Vector3ValueMixer rotationMixer = new();
        readonly Vector3ValueMixer scaleMixer = new();

        public override void Blend(Transform binding, TweenTransformBehaviour behaviour, float weight, float progress)
        {
            positionMixer.TryBlend(behaviour.Position, binding, progress, weight);
            rotationMixer.TryBlend(behaviour.Rotation, binding, progress, weight);
            scaleMixer.TryBlend(behaviour.Scale, binding, progress, weight);
        }

        public override void Apply(Transform binding)
        {
            positionMixer.TryApplyAndClear(binding, (x, binding) => binding.localPosition = x);
            rotationMixer.TryApplyAndClear(binding, (x, binding) => binding.localEulerAngles = x);
            scaleMixer.TryApplyAndClear(binding, (x, binding) => binding.localScale = x);
        }
    }
}
