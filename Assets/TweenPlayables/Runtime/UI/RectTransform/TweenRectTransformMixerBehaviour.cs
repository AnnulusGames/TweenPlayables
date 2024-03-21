using UnityEngine;

namespace TweenPlayables
{
    public class TweenRectTransformMixerBehaviour : TweenAnimationMixerBehaviour<RectTransform, TweenRectTransformBehaviour>
    {
        readonly Vector3ValueMixer anchoredPositionMixer = new();
        readonly Vector2ValueMixer sizeDeltaMixer = new();
        readonly Vector3ValueMixer rotationMixer = new();
        readonly Vector3ValueMixer scaleMixer = new();

        public override void Blend(RectTransform binding, TweenRectTransformBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.AnchoredPosition.IsActive)
            {
                anchoredPositionMixer.Blend(behaviour.AnchoredPosition.Evaluate(binding, progress), weight);
            }
            if (behaviour.SizeDelta.IsActive)
            {
                sizeDeltaMixer.Blend(behaviour.SizeDelta.Evaluate(binding, progress), weight);
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

        public override void Apply(RectTransform binding)
        {
            if (anchoredPositionMixer.HasValue)
            {
                binding.anchoredPosition3D = anchoredPositionMixer.Value;
            }
            if (sizeDeltaMixer.HasValue)
            {
                binding.sizeDelta = sizeDeltaMixer.Value;
            }
            if (rotationMixer.HasValue)
            {
                binding.localEulerAngles = rotationMixer.Value;
            }
            if (scaleMixer.HasValue)
            {
                binding.localScale = scaleMixer.Value;
            }

            anchoredPositionMixer.Clear();
            sizeDeltaMixer.Clear();
            rotationMixer.Clear();
            scaleMixer.Clear();
        }
    }
}
