using UnityEngine.UI;

namespace TweenPlayables
{
    public sealed class TweenGraphicMixerBehaviour : TweenAnimationMixerBehaviour<Graphic, TweenGraphicBehaviour>
    {
        readonly ColorValueMixer colorMixer = new();

        public override void Blend(Graphic binding, TweenGraphicBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.Color.IsActive)
            {
                colorMixer.Blend(behaviour.Color.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(Graphic binding)
        {
            if (colorMixer.HasValue)
            {
                binding.color = colorMixer.Value;
            }

            colorMixer.Clear();
        }
    }
}