using UnityEngine;

namespace TweenPlayables
{
    public class TweenAudioSourceMixerBehaviour : TweenAnimationMixerBehaviour<AudioSource, TweenAudioSourceBehaviour>
    {
        private FloatValueMixer volumeMixer = new();
        private FloatValueMixer pitchMixer = new();

        public override void Blend(AudioSource binding, TweenAudioSourceBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.volume.IsActive)
            {
                volumeMixer.Blend(behaviour.volume.Evaluate(binding, progress), weight);
            }

            if (behaviour.pitch.IsActive)
            {
                pitchMixer.Blend(behaviour.pitch.Evaluate(binding, progress), weight);
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