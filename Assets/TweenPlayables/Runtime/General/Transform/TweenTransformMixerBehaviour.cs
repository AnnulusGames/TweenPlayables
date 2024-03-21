using UnityEngine;

namespace TweenPlayables
{
    public class TweenTransformMixerBehaviour : TweenAnimationMixerBehaviour<Transform, TweenTransformBehaviour>
    {
        private Vector3ValueMixer positionMixer = new();
        private Vector3ValueMixer rotationMixer = new();
        private Vector3ValueMixer scaleMixer = new();

        public override void Blend(Transform binding, TweenTransformBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.position.IsActive)
            {
                positionMixer.Blend(behaviour.position.Evaluate(binding, progress), weight);
            }

            if (behaviour.rotation.IsActive)
            {
                rotationMixer.Blend(behaviour.rotation.Evaluate(binding, progress), weight);
            }

            if (behaviour.scale.IsActive)
            {
                scaleMixer.Blend(behaviour.scale.Evaluate(binding, progress), weight);
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
