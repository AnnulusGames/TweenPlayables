#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(CanvasGroup))]
    [TrackClipType(typeof(TweenCanvasGroupClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Canvas Group")]
#endif
    public sealed class TweenCanvasGroupTrack : TweenAnimationTrack<CanvasGroup, TweenCanvasGroupMixerBehaviour, TweenCanvasGroupBehaviour> { }
}