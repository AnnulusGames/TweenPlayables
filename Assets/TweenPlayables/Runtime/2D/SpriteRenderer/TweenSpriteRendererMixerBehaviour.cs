using UnityEngine;

namespace TweenPlayables
{
    public sealed class TweenSpriteRendererMixerBehaviour : TweenAnimationMixerBehaviour<SpriteRenderer, TweenSpriteRendererBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();

        public override void Blend(SpriteRenderer binding, TweenSpriteRendererBehaviour behaviour, float weight, float progress)
        {
            colorMixer.TryBlend(behaviour.Color, binding, progress, weight);
        }

        public override void Apply(SpriteRenderer binding)
        {
            colorMixer.TryApplyAndClear(binding, (x, binding) => binding.color = x);
        }
    }
}