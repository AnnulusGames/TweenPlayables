using System;

namespace TweenPlayables
{
    public static class ValueMixerExtensions
    {
        public static bool TryBlend<T>(this ValueMixer<T> mixer, ReadOnlyTweenParameter<T> parameter, object binding, float progress, float weight)
        {
            if (parameter.IsActive)
            {
                mixer.Blend(parameter.Evaluate(binding, progress), weight);
                return true;
            }

            return false;
        }

        public static bool TryApplyAndClear<T>(this ValueMixer<T> mixer, Action<T> action)
        {
            if (mixer.HasValue)
            {
                action(mixer.Value);
                mixer.Clear();
                return true;
            }

            return false;
        }

        public static bool TryApplyAndClear<T, TBinding>(this ValueMixer<T> mixer, TBinding target, Action<T, TBinding> action)
        {
            if (mixer.HasValue)
            {
                action(mixer.Value, target);
                mixer.Clear();
                return true;
            }

            return false;
        }
    }
}