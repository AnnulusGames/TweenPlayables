using System;
using UnityEngine;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenAudioSourceBehaviour : TweenAnimationBehaviour<AudioSource>
    {
        [SerializeField] FloatTweenParameter volume;
        [SerializeField] FloatTweenParameter pitch;

        public ReadOnlyTweenParameter<float> Volume => volume;
        public ReadOnlyTweenParameter<float> Pitch => pitch;

        public override void OnTweenInitialize(AudioSource playerData)
        {
            volume.SetInitialValue(playerData, playerData.volume);
            pitch.SetInitialValue(playerData, playerData.pitch);
        }
    }
}