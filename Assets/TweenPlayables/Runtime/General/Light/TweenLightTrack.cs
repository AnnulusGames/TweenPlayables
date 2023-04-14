#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Light))]
    [TrackClipType(typeof(TweenLightClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/General/Tween Light Track")]
#endif
    public class TweenLightTrack : TweenAnimationTrack<Light, TweenLightMixerBehaviour, TweenLightBehaviour> { }
}