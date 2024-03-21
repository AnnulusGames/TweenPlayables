using UnityEngine;

namespace TweenPlayables
{
    public class TweenCameraMixerBehaviour : TweenAnimationMixerBehaviour<Camera, TweenCameraBehaviour>
    {
        private FloatValueMixer orthoSizeMixer = new();
        private FloatValueMixer fovMixer = new();
        private ColorValueMixer backgroundColorMixer = new();

        public override void Blend(Camera binding, TweenCameraBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.orthographicSize.IsActive)
            {
                orthoSizeMixer.Blend(behaviour.orthographicSize.Evaluate(binding, progress), weight);
            }

            if (behaviour.fieldOfView.IsActive)
            {
                fovMixer.Blend(behaviour.fieldOfView.Evaluate(binding, progress), weight);
            }

            if (behaviour.backgroundColor.IsActive)
            {
                backgroundColorMixer.Blend(behaviour.backgroundColor.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Camera binding)
        {
            if (orthoSizeMixer.HasValue)
            {
                binding.orthographicSize = orthoSizeMixer.Value;
            }
            if (fovMixer.HasValue)
            {
                binding.fieldOfView = fovMixer.Value;
            }
            if (backgroundColorMixer.HasValue)
            {
                binding.backgroundColor = backgroundColorMixer.Value;
            }

            orthoSizeMixer.Clear();
            fovMixer.Clear();
            backgroundColorMixer.Clear();
        }
    }

}