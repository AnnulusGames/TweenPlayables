using UnityEngine;

namespace TweenPlayables
{
    public sealed class TweenAudioSourceMixerBehaviour : TweenAnimationMixerBehaviour<AudioSource, TweenAudioSourceBehaviour>
    {
        readonly FloatValueMixer volumeMixer = new();
        readonly FloatValueMixer pitchMixer = new();

        public override void Blend(AudioSource binding, TweenAudioSourceBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.Volume.IsActive)
            {
                volumeMixer.Blend(behaviour.Volume.Evaluate(binding, progress), weight);
            }

            if (behaviour.Pitch.IsActive)
            {
                pitchMixer.Blend(behaviour.Pitch.Evaluate(binding, progress), weight);
            }
        }

        public override void Apply(AudioSource binding)
        {
            if (volumeMixer.HasValue)
            {
                binding.volume = volumeMixer.Value;
            }
            if (pitchMixer.HasValue)
            {
                binding.pitch = pitchMixer.Value;
            }

            volumeMixer.Clear();
            pitchMixer.Clear();
        }
    }
}