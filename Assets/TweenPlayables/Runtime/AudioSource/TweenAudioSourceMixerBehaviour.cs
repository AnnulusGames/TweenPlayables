using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    public class TweenAudioSourceMixerBehaviour : TweenAnimationMixerBehaviour<AudioSource, TweenAudioSourceBehaviour>
    {
        private FloatValueMixer volumeMixer = new FloatValueMixer();
        private FloatValueMixer pitchMixer = new FloatValueMixer();

        public override void Blend(TweenAudioSourceBehaviour behaviour, float weight, float progress)
        {
            if (behaviour.volume.active)
            {
                volumeMixer.Blend(behaviour.volume.Evaluate(progress), weight);
            }

            if (behaviour.pitch.active)
            {
                pitchMixer.Blend(behaviour.pitch.Evaluate(progress), weight);
            }
        }

        public override void Apply(AudioSource binding)
        {
            if (volumeMixer.ValueCount > 0)
            {
                binding.volume = volumeMixer.Value;
            }
            if (pitchMixer.ValueCount > 0)
            {
                binding.pitch = pitchMixer.Value;
            }

            volumeMixer.Clear();
            pitchMixer.Clear();
        }
    }

}