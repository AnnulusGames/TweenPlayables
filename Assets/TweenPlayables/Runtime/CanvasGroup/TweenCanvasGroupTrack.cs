using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(CanvasGroup))]
    [TrackClipType(typeof(TweenCanvasGroupClip))]
    public class TweenCanvasGroupTrack : TweenAnimationTrack<CanvasGroup, TweenCanvasGroupMixerBehaviour, TweenCanvasGroupBehaviour> { }
}