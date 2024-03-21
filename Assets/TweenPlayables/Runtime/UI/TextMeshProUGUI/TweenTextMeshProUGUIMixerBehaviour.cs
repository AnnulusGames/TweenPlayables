using TMPro;

namespace TweenPlayables
{
    public sealed class TweenTextMeshProUGUIMixerBehaviour : TweenAnimationMixerBehaviour<TextMeshProUGUI, TweenTextMeshProUGUIBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();
        readonly FloatValueMixer fontSizeMixer = new();
        readonly FloatValueMixer characterSpacingMixer = new();
        readonly FloatValueMixer wordSpacingMixer = new();
        readonly FloatValueMixer lineSpacingMixer = new();
        readonly FloatValueMixer paragraphSpacingMixer = new();
        readonly VertexGradientValueMixer colorGradientMixer = new();

        string textValue = null;

        public override void Blend(TextMeshProUGUI binding, TweenTextMeshProUGUIBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.Color.IsActive)
            {
                colorMixer.Blend(behaviour.Color.Evaluate(binding, progress), weight);
            }
            if (behaviour.FontSize.IsActive)
            {
                fontSizeMixer.Blend(behaviour.FontSize.Evaluate(binding, progress), weight);
            }
            if (behaviour.CharacterSpacing.IsActive)
            {
                characterSpacingMixer.Blend(behaviour.CharacterSpacing.Evaluate(binding, progress), weight);
            }
            if (behaviour.WordSpacing.IsActive)
            {
                wordSpacingMixer.Blend(behaviour.WordSpacing.Evaluate(binding, progress), weight);
            }
            if (behaviour.LineSpacing.IsActive)
            {
                lineSpacingMixer.Blend(behaviour.LineSpacing.Evaluate(binding, progress), weight);
            }
            if (behaviour.ParagraphSpacing.IsActive)
            {
                paragraphSpacingMixer.Blend(behaviour.ParagraphSpacing.Evaluate(binding, progress), weight);
            }
            if (behaviour.ColorGradient.IsActive)
            {
                colorGradientMixer.Blend(behaviour.ColorGradient.Evaluate(binding, progress), weight);
            }
            if (behaviour.Text.IsActive)
            {
                textValue = behaviour.Text.Evaluate(binding, progress);
            }
        }

        public override void Apply(TextMeshProUGUI binding)
        {
            if (colorMixer.HasValue)
            {
                binding.color = colorMixer.Value;
            }
            if (fontSizeMixer.HasValue)
            {
                binding.fontSize = fontSizeMixer.Value;
            }
            if (characterSpacingMixer.HasValue)
            {
                binding.characterSpacing = characterSpacingMixer.Value;
            }
            if (wordSpacingMixer.HasValue)
            {
                binding.wordSpacing = wordSpacingMixer.Value;
            }
            if (lineSpacingMixer.HasValue)
            {
                binding.lineSpacing = lineSpacingMixer.Value;
            }
            if (paragraphSpacingMixer.HasValue)
            {
                binding.paragraphSpacing = paragraphSpacingMixer.Value;
            }
            if (colorGradientMixer.HasValue)
            {
                binding.colorGradient = colorGradientMixer.Value;
            }
            if (textValue != null)
            {
                binding.text = textValue;
            }

            colorMixer.Clear();
            fontSizeMixer.Clear();
            characterSpacingMixer.Clear();
            wordSpacingMixer.Clear();
            lineSpacingMixer.Clear();
            paragraphSpacingMixer.Clear();
            colorGradientMixer.Clear();
            textValue = null;
        }
    }
}