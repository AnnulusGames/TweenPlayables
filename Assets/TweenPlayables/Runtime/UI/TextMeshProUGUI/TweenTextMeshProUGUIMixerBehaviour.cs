using System;
using TMPro;

namespace TweenPlayables
{
    [Obsolete]
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
            colorMixer.TryBlend(behaviour.Color, binding, progress, weight);
            fontSizeMixer.TryBlend(behaviour.FontSize, binding, progress, weight);
            characterSpacingMixer.TryBlend(behaviour.CharacterSpacing, binding, progress, weight);
            wordSpacingMixer.TryBlend(behaviour.WordSpacing, binding, progress, weight);
            lineSpacingMixer.TryBlend(behaviour.LineSpacing, binding, progress, weight);
            paragraphSpacingMixer.TryBlend(behaviour.ParagraphSpacing, binding, progress, weight);
            colorGradientMixer.TryBlend(behaviour.ColorGradient, binding, progress, weight);

            if (behaviour.Text.IsActive)
            {
                textValue = behaviour.Text.Evaluate(binding, progress);
            }
        }

        public override void Apply(TextMeshProUGUI binding)
        {
            colorMixer.TryApplyAndClear(binding, (x, binding) => binding.color = x);
            fontSizeMixer.TryApplyAndClear(binding, (x, binding) => binding.fontSize = x);
            characterSpacingMixer.TryApplyAndClear(binding, (x, binding) => binding.characterSpacing = x);
            wordSpacingMixer.TryApplyAndClear(binding, (x, binding) => binding.wordSpacing = x);
            lineSpacingMixer.TryApplyAndClear(binding, (x, binding) => binding.lineSpacing = x);
            paragraphSpacingMixer.TryApplyAndClear(binding, (x, binding) => binding.paragraphSpacing = x);
            colorGradientMixer.TryApplyAndClear(binding, (x, binding) => binding.colorGradient = x);

            if (textValue != null)
            {
                binding.text = textValue;
                textValue = null;
            }
        }
    }
}