using UnityEngine;

namespace TweenPlayables
{
    public sealed class TweenLightMixerBehaviour : TweenAnimationMixerBehaviour<Light, TweenLightBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();
        readonly FloatValueMixer intensityMixer = new();
        readonly FloatValueMixer shadowStrengthMixer = new();

        public override void Blend(Light binding, TweenLightBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.Color.IsActive)
            {
                colorMixer.Blend(behaviour.Color.Evaluate(binding, progress), weight);
            }
            if (behaviour.Intensity.IsActive)
            {
                intensityMixer.Blend(behaviour.Intensity.Evaluate(binding, progress), weight);
            }
            if (behaviour.ShadowStrength.IsActive)
            {
                shadowStrengthMixer.Blend(behaviour.ShadowStrength.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Light binding)
        {
            if (colorMixer.HasValue) binding.color = colorMixer.Value;
            if (intensityMixer.HasValue) binding.intensity = intensityMixer.Value;
            if (shadowStrengthMixer.HasValue) binding.shadowStrength = shadowStrengthMixer.Value;

            colorMixer.Clear();
            intensityMixer.Clear();
            shadowStrengthMixer.Clear();
        }
    }
}