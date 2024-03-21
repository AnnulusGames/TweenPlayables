using TMPro;

namespace TweenPlayables
{
    public class TweenTextMeshProUGUIMixerBehaviour : TweenAnimationMixerBehaviour<TextMeshProUGUI, TweenTextMeshProUGUIBehaviour>
    {
        private ColorValueMixer colorMixer = new();
        private FloatValueMixer fontSizeMixer = new();
        private FloatValueMixer characterSpacingMixer = new();
        private FloatValueMixer wordSpacingMixer = new();
        private FloatValueMixer lineSpacingMixer = new();
        private FloatValueMixer paragraphSpacingMixer = new();
        private VertexGradientValueMixer colorGradientMixer = new();
        private string textValue = null;

        public override void Blend(TextMeshProUGUI binding, TweenTextMeshProUGUIBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.color.IsActive)
            {
                colorMixer.Blend(behaviour.color.Evaluate(binding, progress), weight);
            }
            if (behaviour.fontSize.IsActive)
            {
                fontSizeMixer.Blend(behaviour.fontSize.Evaluate(binding, progress), weight);
            }
            if (behaviour.characterSpacing.IsActive)
            {
                characterSpacingMixer.Blend(behaviour.characterSpacing.Evaluate(binding, progress), weight);
            }
            if (behaviour.wordSpacing.IsActive)
            {
                wordSpacingMixer.Blend(behaviour.wordSpacing.Evaluate(binding, progress), weight);
            }
            if (behaviour.lineSpacing.IsActive)
            {
                lineSpacingMixer.Blend(behaviour.lineSpacing.Evaluate(binding, progress), weight);
            }
            if (behaviour.paragraphSpacing.IsActive)
            {
                paragraphSpacingMixer.Blend(behaviour.paragraphSpacing.Evaluate(binding, progress), weight);
            }
            if (behaviour.colorGradient.IsActive)
            {
                colorGradientMixer.Blend(behaviour.colorGradient.Evaluate(binding, progress), weight);
            }
            if (behaviour.text.IsActive)
            {
                textValue = behaviour.text.Evaluate(binding, progress);
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