using UnityEngine;

namespace TweenPlayables
{
    public class TweenRectTransformMixerBehaviour : TweenAnimationMixerBehaviour<RectTransform, TweenRectTransformBehaviour>
    {
        private Vector3ValueMixer anchoredPositionMixer = new Vector3ValueMixer();
        private Vector2ValueMixer sizeDeltaMixer = new Vector2ValueMixer();
        private Vector3ValueMixer rotationMixer = new Vector3ValueMixer();
        private Vector3ValueMixer scaleMixer = new Vector3ValueMixer();

        public override void Blend(RectTransform binding, TweenRectTransformBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.anchoredPosition.IsActive)
            {
                anchoredPositionMixer.Blend(behaviour.anchoredPosition.Evaluate(binding, progress), weight);
            }
            if (behaviour.sizeDelta.IsActive)
            {
                sizeDeltaMixer.Blend(behaviour.sizeDelta.Evaluate(binding, progress), weight);
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

        public override void Apply(RectTransform binding)
        {
            if (anchoredPositionMixer.ValueCount > 0)
            {
                binding.anchoredPosition3D = anchoredPositionMixer.Value;
            }
            if (sizeDeltaMixer.ValueCount > 0)
            {
                binding.sizeDelta = sizeDeltaMixer.Value;
            }
            if (rotationMixer.ValueCount > 0)
            {
                binding.localEulerAngles = rotationMixer.Value;
            }
            if (scaleMixer.ValueCount > 0)
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
