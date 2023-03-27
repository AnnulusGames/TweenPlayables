using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(AudioSource))]
    [TrackClipType(typeof(TweenAudioSourceClip))]
    public class TweenAudioSourceTrack : TweenAnimationTrack<AudioSource, TweenAudioSourceMixerBehaviour, TweenAudioSourceBehaviour>
    {

    }
}