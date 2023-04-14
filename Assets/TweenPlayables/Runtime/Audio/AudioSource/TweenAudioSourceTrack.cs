#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(AudioSource))]
    [TrackClipType(typeof(TweenAudioSourceClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/Audio/Tween AudioSource Track")]
#endif
    public class TweenAudioSourceTrack : TweenAnimationTrack<AudioSource, TweenAudioSourceMixerBehaviour, TweenAudioSourceBehaviour>
    {

    }
}