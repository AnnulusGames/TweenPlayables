using UnityEngine;

namespace TweenPlayables
{
    public sealed class TweenAudioSourceMixerBehaviour : TweenAnimationMixerBehaviour<AudioSource, TweenAudioSourceBehaviour>
    {
        readonly FloatValueMixer volumeMixer = new();
        readonly FloatValueMixer pitchMixer = new();

        public override void Blend(AudioSource binding, TweenAudioSourceBehaviour behaviour, float weight, float progress)
        {
            volumeMixer.TryBlend(behaviour.Volume, binding, progress, weight);
            pitchMixer.TryBlend(behaviour.Pitch, binding, progress, weight);
        }

        public override void Apply(AudioSource binding)
        {
            volumeMixer.TryApplyAndClear(binding, (x, binding) => binding.volume = x);
            pitchMixer.TryApplyAndClear(binding, (x, binding) => binding.pitch = x);
        }
    }
}