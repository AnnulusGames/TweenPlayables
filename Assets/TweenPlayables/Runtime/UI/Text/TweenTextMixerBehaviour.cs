using UnityEngine.UI;

namespace TweenPlayables
{
    public class TweenTextMixerBehaviour : TweenAnimationMixerBehaviour<Text, TweenTextBehaviour>
    {
        private ColorValueMixer colorMixer = new();
        private IntValueMixer fontSizeMixer = new();
        private FloatValueMixer lineSpacingMixer = new();
        private string textValue = null;

        public override void Blend(Text binding, TweenTextBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.color.IsActive)
            {
                colorMixer.Blend(behaviour.color.Evaluate(binding, progress), weight);
            }
            if (behaviour.fontSize.IsActive)
            {
                fontSizeMixer.Blend(behaviour.fontSize.Evaluate(binding, progress), weight);
            }
            if (behaviour.lineSpacing.IsActive)
            {
                lineSpacingMixer.Blend(behaviour.lineSpacing.Evaluate(binding, progress), weight);
            }
            if (behaviour.text.IsActive)
            {
                textValue = behaviour.text.Evaluate(binding, progress);
            }
        }

        public override void Apply(Text binding)
        {
            if (colorMixer.HasValue)
            {
                binding.color = colorMixer.Value;
            }
            if (fontSizeMixer.HasValue)
            {
                binding.fontSize = fontSizeMixer.Value;
            }
            if (lineSpacingMixer.HasValue)
            {
                binding.lineSpacing = lineSpacingMixer.Value;
            }
            if (textValue != null)
            {
                binding.text = textValue;
            }

            colorMixer.Clear();
            fontSizeMixer.Clear();
            lineSpacingMixer.Clear();
            textValue = null;
        }
    }
}