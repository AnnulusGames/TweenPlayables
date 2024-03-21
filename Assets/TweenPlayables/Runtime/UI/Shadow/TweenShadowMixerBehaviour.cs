using UnityEngine.UI;

namespace TweenPlayables
{
    public sealed class TweenShadowMixerBehaviour : TweenAnimationMixerBehaviour<Shadow, TweenShadowBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();
        readonly Vector3ValueMixer distanceMixer = new();

        public override void Blend(Shadow binding, TweenShadowBehaviour behaviour, float weight, float progress)
        {
            colorMixer.TryBlend(behaviour.Color, binding, progress, weight);
            distanceMixer.TryBlend(behaviour.Distance, binding, progress, weight);
        }

        public override void Apply(Shadow binding)
        {
            colorMixer.TryApplyAndClear(binding, (x, binding) => binding.effectColor = x);
            distanceMixer.TryApplyAndClear(binding, (x, binding) => binding.effectDistance = x);
        }
    }
}