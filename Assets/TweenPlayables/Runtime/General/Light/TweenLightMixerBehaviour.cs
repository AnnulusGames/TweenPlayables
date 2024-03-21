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
            colorMixer.TryBlend(behaviour.Color, binding, progress, weight);
            intensityMixer.TryBlend(behaviour.Intensity, binding, progress, weight);
            shadowStrengthMixer.TryBlend(behaviour.ShadowStrength, binding, progress, weight);
        }

        public override void Apply(Light binding)
        {
            colorMixer.TryApplyAndClear(binding, (x, binding) => binding.color = x);
            intensityMixer.TryApplyAndClear(binding, (x, binding) => binding.intensity = x);
            shadowStrengthMixer.TryApplyAndClear(binding, (x, binding) => binding.shadowStrength = x);
        }
    }
}