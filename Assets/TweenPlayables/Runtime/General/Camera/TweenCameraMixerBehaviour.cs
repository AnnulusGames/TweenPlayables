using UnityEngine;

namespace TweenPlayables
{
    public sealed class TweenCameraMixerBehaviour : TweenAnimationMixerBehaviour<Camera, TweenCameraBehaviour>
    {
        readonly FloatValueMixer orthoSizeMixer = new();
        readonly FloatValueMixer fovMixer = new();
        readonly ColorValueMixer backgroundColorMixer = new();

        public override void Blend(Camera binding, TweenCameraBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.OrthographicSize.IsActive)
            {
                orthoSizeMixer.Blend(behaviour.OrthographicSize.Evaluate(binding, progress), weight);
            }

            if (behaviour.FieldOfView.IsActive)
            {
                fovMixer.Blend(behaviour.FieldOfView.Evaluate(binding, progress), weight);
            }

            if (behaviour.BackgroundColor.IsActive)
            {
                backgroundColorMixer.Blend(behaviour.BackgroundColor.Evaluate(binding, progress), weight);
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