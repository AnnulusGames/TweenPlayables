using UnityEngine;

namespace TweenPlayables
{
    public class TweenTransformMixerBehaviour : TweenAnimationMixerBehaviour<Transform, TweenTransformBehaviour>
    {
        readonly Vector3ValueMixer positionMixer = new();
        readonly Vector3ValueMixer rotationMixer = new();
        readonly Vector3ValueMixer scaleMixer = new();

        public override void Blend(Transform binding, TweenTransformBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.Position.IsActive)
            {
                positionMixer.Blend(behaviour.Position.Evaluate(binding, progress), weight);
            }

            if (behaviour.Rotation.IsActive)
            {
                rotationMixer.Blend(behaviour.Rotation.Evaluate(binding, progress), weight);
            }

            if (behaviour.Scale.IsActive)
            {
                scaleMixer.Blend(behaviour.Scale.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Transform binding)
        {
            if (positionMixer.HasValue)
            {
                binding.localPosition = positionMixer.Value;
            }
            if (rotationMixer.HasValue)
            {
                binding.localEulerAngles = rotationMixer.Value;
            }
            if (scaleMixer.HasValue)
            {
                binding.localScale = scaleMixer.Value;
            }

            positionMixer.Clear();
            rotationMixer.Clear();
            scaleMixer.Clear();
        }
    }
}
