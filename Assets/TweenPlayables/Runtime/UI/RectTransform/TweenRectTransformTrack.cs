#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(RectTransform))]
    [TrackClipType(typeof(TweenRectTransformClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Tween RectTransform Track")]
#endif
    public class TweenRectTransformTrack : TweenAnimationTrack<RectTransform, TweenRectTransformMixerBehaviour, TweenRectTransformBehaviour> { }
}