using UnityEngine.UI;

namespace TweenPlayables
{
    public sealed class TweenGraphicMixerBehaviour : TweenAnimationMixerBehaviour<Graphic, TweenGraphicBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();

        public override void Blend(Graphic binding, TweenGraphicBehaviour behaviour, float weight, float progress)
        {
            colorMixer.TryBlend(behaviour.Color, binding, progress, weight);
        }

        public override void Apply(Graphic binding)
        {
            colorMixer.TryApplyAndClear(binding, (x, binding) => binding.color = x);
        }
    }
}