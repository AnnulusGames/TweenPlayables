#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(TweenTransformClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/General/Tween Transform Track")]
#endif
    public sealed class TweenTransformTrack : TweenAnimationTrack<Transform, TweenTransformMixerBehaviour, TweenTransformBehaviour> { }
}