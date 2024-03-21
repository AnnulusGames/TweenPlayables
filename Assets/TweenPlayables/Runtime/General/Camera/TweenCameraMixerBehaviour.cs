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
            orthoSizeMixer.TryBlend(behaviour.OrthographicSize, binding, progress, weight);
            fovMixer.TryBlend(behaviour.FieldOfView, binding, progress, weight);
            backgroundColorMixer.TryBlend(behaviour.BackgroundColor, binding, progress, weight);
        }

        public override void Apply(Camera binding)
        {
            orthoSizeMixer.TryApplyAndClear(binding, (x, binding) => binding.orthographicSize = x);
            fovMixer.TryApplyAndClear(binding, (x, binding) => binding.fieldOfView = x);
            backgroundColorMixer.TryApplyAndClear(binding, (x, binding) => binding.backgroundColor = x);
        }
    }
}