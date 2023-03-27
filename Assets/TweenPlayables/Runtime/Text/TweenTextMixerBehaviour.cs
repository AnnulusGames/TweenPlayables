using UnityEngine.UI;

namespace AnnulusGames.TweenPlayables
{
    public class TweenTextMixerBehaviour : TweenAnimationMixerBehaviour<Text, TweenTextBehaviour>
    {
        private ColorValueMixer colorMixer = new ColorValueMixer();
        private IntValueMixer fontSizeMixer = new IntValueMixer();
        private FloatValueMixer lineSpacingMixer = new FloatValueMixer();

        public override void Blend(Text binding, TweenTextBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.color.active)
            {
                colorMixer.Blend(behaviour.color.Evaluate(binding, progress), weight);
            }
            if (behaviour.fontSize.active)
            {
                fontSizeMixer.Blend(behaviour.fontSize.Evaluate(binding, progress), weight);
            }
            if (behaviour.lineSpacing.active)
            {
                lineSpacingMixer.Blend(behaviour.lineSpacing.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Text binding)
        {
            if (colorMixer.ValueCount > 0)
            {
                binding.color = colorMixer.Value;
            }
            if (fontSizeMixer.ValueCount > 0)
            {
                binding.fontSize = fontSizeMixer.Value;
            }
            if (lineSpacingMixer.ValueCount > 0)
            {
                binding.lineSpacing = lineSpacingMixer.Value;
            }

            colorMixer.Clear();
            fontSizeMixer.Clear();
            lineSpacingMixer.Clear();
        }
    }
}