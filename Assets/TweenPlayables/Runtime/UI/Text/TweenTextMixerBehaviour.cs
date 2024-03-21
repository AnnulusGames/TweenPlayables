using UnityEngine.UI;

namespace TweenPlayables
{
    public class TweenTextMixerBehaviour : TweenAnimationMixerBehaviour<Text, TweenTextBehaviour>
    {
        private readonly ColorValueMixer colorMixer = new();
        private readonly IntValueMixer fontSizeMixer = new();
        private readonly FloatValueMixer lineSpacingMixer = new();
        private string textValue = null;

        public override void Blend(Text binding, TweenTextBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.Color.IsActive)
            {
                colorMixer.Blend(behaviour.Color.Evaluate(binding, progress), weight);
            }
            if (behaviour.FontSize.IsActive)
            {
                fontSizeMixer.Blend(behaviour.FontSize.Evaluate(binding, progress), weight);
            }
            if (behaviour.LineSpacing.IsActive)
            {
                lineSpacingMixer.Blend(behaviour.LineSpacing.Evaluate(binding, progress), weight);
            }
            if (behaviour.Text.IsActive)
            {
                textValue = behaviour.Text.Evaluate(binding, progress);
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