using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    public class TweenLightMixerBehaviour : TweenAnimationMixerBehaviour<Light, TweenLightBehaviour>
    {
        private Color blendedColor;
        private int colorInputCount;

        private float blendedIntensity;
        private int intensityInputCount;

        private float blendedShadowStrength;
        private int shadowStrengthInputCount;

        public override void Blend(TweenLightBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.color.active)
            {
                blendedColor += behaviour.color.Evaluate(progress) * weight;
                colorInputCount++;
            }
            if (behaviour.intensity.active)
            {
                blendedIntensity += behaviour.intensity.Evaluate(progress) * weight;
                intensityInputCount++;
            }
            if (behaviour.shadowStrength.active)
            {
                blendedShadowStrength += behaviour.shadowStrength.Evaluate(progress) * weight;
                shadowStrengthInputCount++;
            }
        }

        public override void Apply(Light binding)
        {
            if (colorInputCount > 0)
            {
                binding.color = blendedColor;
            }
            if (intensityInputCount > 0)
            {
                binding.intensity = blendedIntensity;
            }
            if (shadowStrengthInputCount > 0)
            {
                binding.shadowStrength = blendedShadowStrength;
            }

            blendedColor = Color.clear;
            colorInputCount = 0;
            blendedIntensity = 0f;
            intensityInputCount = 0;
            blendedShadowStrength = 0f;
            shadowStrengthInputCount = 0;
        }
    }

}