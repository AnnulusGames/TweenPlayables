using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    public class TweenCameraMixerBehaviour : TweenAnimationMixerBehaviour<Camera, TweenCameraBehaviour>
    {
        private FloatValueMixer orthoSizeMixer = new FloatValueMixer();
        private FloatValueMixer fovMixer = new FloatValueMixer();
        private ColorValueMixer backgroundColorMixer = new ColorValueMixer();

        public override void Blend(Camera binding, TweenCameraBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.orthographicSize.active)
            {
                orthoSizeMixer.Blend(behaviour.orthographicSize.Evaluate(binding, progress), weight);
            }

            if (behaviour.fieldOfView.active)
            {
                fovMixer.Blend(behaviour.fieldOfView.Evaluate(binding, progress), weight);
            }

            if (behaviour.backgroundColor.active)
            {
                backgroundColorMixer.Blend(behaviour.backgroundColor.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Camera binding)
        {
            if (orthoSizeMixer.ValueCount > 0)
            {
                binding.orthographicSize = orthoSizeMixer.Value;
            }
            if (fovMixer.ValueCount > 0)
            {
                binding.fieldOfView = fovMixer.Value;
            }
            if (backgroundColorMixer.ValueCount > 0)
            {
                binding.backgroundColor = backgroundColorMixer.Value;
            }

            orthoSizeMixer.Clear();
            fovMixer.Clear();
            backgroundColorMixer.Clear();
        }
    }

}