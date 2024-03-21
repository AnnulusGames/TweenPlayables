using UnityEngine.UI;

namespace TweenPlayables
{
    public sealed class TweenTextMixerBehaviour : TweenAnimationMixerBehaviour<Text, TweenTextBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();
        readonly IntValueMixer fontSizeMixer = new();
        readonly FloatValueMixer lineSpacingMixer = new();

        string textValue = null;

        public override void Blend(Text binding, TweenTextBehaviour behaviour, float weight, float progress)
        {
            colorMixer.TryBlend(behaviour.Color, binding, progress, weight);
            fontSizeMixer.TryBlend(behaviour.FontSize, binding, progress, weight);
            lineSpacingMixer.TryBlend(behaviour.LineSpacing, binding, progress, weight);

            if (behaviour.Text.IsActive)
            {
                textValue = behaviour.Text.Evaluate(binding, progress);
            }
        }

        public override void Apply(Text binding)
        {
            colorMixer.TryApplyAndClear(binding, (x, binding) => binding.color = x);
            fontSizeMixer.TryApplyAndClear(binding, (x, binding) => binding.fontSize = x);
            lineSpacingMixer.TryApplyAndClear(binding, (x, binding) => binding.lineSpacing = x);

            if (textValue != null)
            {
                binding.text = textValue;
                textValue = null;
            }
        }
    }
}