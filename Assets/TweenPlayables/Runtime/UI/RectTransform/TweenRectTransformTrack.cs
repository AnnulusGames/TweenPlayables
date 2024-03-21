#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(RectTransform))]
    [TrackClipType(typeof(TweenRectTransformClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Tween RectTransform Track")]
#endif
    public sealed class TweenRectTransformTrack : TweenAnimationTrack<RectTransform, TweenRectTransformMixerBehaviour, TweenRectTransformBehaviour> { }
}