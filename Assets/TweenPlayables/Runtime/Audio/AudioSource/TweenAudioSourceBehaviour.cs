using System;
using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public class TweenAudioSourceBehaviour : TweenAnimationBehaviour<AudioSource>
    {
        public FloatTweenParameter volume;
        public FloatTweenParameter pitch;

        public override void OnTweenInitialize(AudioSource playerData)
        {
            volume.SetInitialValue(playerData, playerData.volume);
            pitch.SetInitialValue(playerData, playerData.pitch);
        }
    }

}