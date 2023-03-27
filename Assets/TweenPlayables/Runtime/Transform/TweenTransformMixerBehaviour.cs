using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    public class TweenTransformMixerBehaviour : TweenAnimationMixerBehaviour<Transform, TweenTransformBehaviour>
    {
        private Vector3ValueMixer positionMixer = new Vector3ValueMixer();
        private Vector3ValueMixer rotationMixer = new Vector3ValueMixer();
        private Vector3ValueMixer scaleMixer = new Vector3ValueMixer();

        public override void Blend(Transform binding, TweenTransformBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.position.active)
            {
                positionMixer.Blend(behaviour.position.Evaluate(binding, progress), weight);
            }

            if (behaviour.rotation.active)
            {
                rotationMixer.Blend(behaviour.rotation.Evaluate(binding, progress), weight);
            }

            if (behaviour.scale.active)
            {
                scaleMixer.Blend(behaviour.scale.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Transform binding)
        {
            if (positionMixer.ValueCount > 0)
            {
                binding.localPosition = positionMixer.Value;
            }
            if (rotationMixer.ValueCount > 0)
            {
                binding.localEulerAngles = rotationMixer.Value;
            }
            if (scaleMixer.ValueCount > 0)
            {
                binding.localScale = scaleMixer.Value;
            }

            positionMixer.Clear();
            rotationMixer.Clear();
            scaleMixer.Clear();
        }
    }
}
