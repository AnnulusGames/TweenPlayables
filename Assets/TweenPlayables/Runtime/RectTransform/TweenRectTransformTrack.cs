using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(RectTransform))]
    [TrackClipType(typeof(TweenRectTransformClip))]
    public class TweenRectTransformTrack : TweenAnimationTrack<RectTransform, TweenRectTransformMixerBehaviour, TweenRectTransformBehaviour> { }
}