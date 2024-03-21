#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(Light))]
    [TrackClipType(typeof(TweenLightClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/General/Light")]
#endif
    public sealed class TweenLightTrack : TweenAnimationTrack<Light, TweenLightMixerBehaviour, TweenLightBehaviour> { }
}