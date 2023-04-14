#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(CanvasGroup))]
    [TrackClipType(typeof(TweenCanvasGroupClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Tween CanvasGroup Track")]
#endif
    public class TweenCanvasGroupTrack : TweenAnimationTrack<CanvasGroup, TweenCanvasGroupMixerBehaviour, TweenCanvasGroupBehaviour> { }
}