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
            volume.standardValue = playerData.volume;
            pitch.standardValue = playerData.pitch;
        }
    }

}