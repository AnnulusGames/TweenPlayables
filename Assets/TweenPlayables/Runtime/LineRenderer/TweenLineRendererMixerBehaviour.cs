using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    public class TweenLineRendererMixerBehaviour : TweenAnimationMixerBehaviour<LineRenderer, TweenLineRendererBehaviour>
    {
        private Color blendedStartColor;
        private int startColorInputCount;
        private Color blendedEndColor;
        private int endColorInputCount;

        private float blendedStartWidth;
        private int startWidthInputCount;
        private float blendedEndWidth;
        private int endWidthInputCount;

        public override void Blend(TweenLineRendererBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.startColor.active)
            {
                blendedStartColor += behaviour.startColor.Evaluate(progress) * weight;
                startColorInputCount++;
            }
            if (behaviour.endColor.active)
            {
                blendedEndColor += behaviour.endColor.Evaluate(progress) * weight;
                endColorInputCount++;
            }
            if (behaviour.startWidth.active)
            {
                blendedStartWidth += behaviour.startWidth.Evaluate(progress) * weight;
                startWidthInputCount++;
            }
            if (behaviour.endWidth.active)
            {
                blendedEndWidth += behaviour.endWidth.Evaluate(progress) * weight;
                endWidthInputCount++;
            }
        }

        public override void Apply(LineRenderer binding)
        {
            if (startColorInputCount > 0)
            {
                binding.startColor = blendedStartColor;
            }
            if (endColorInputCount > 0)
            {
                binding.endColor = blendedEndColor;
            }
            if (startWidthInputCount > 0)
            {
                binding.startWidth = blendedStartWidth;
            }
            if (endWidthInputCount > 0)
            {
                binding.endWidth = blendedEndWidth;
            }

            blendedStartColor = Color.clear;
            startColorInputCount = 0;
            blendedEndColor = Color.clear;
            endColorInputCount = 0;
            blendedStartWidth = 0f;
            startWidthInputCount = 0;
            blendedEndWidth = 0f;
            endWidthInputCount = 0;
        }
    }

}