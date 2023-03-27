using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Transform))]
    [TrackClipType(typeof(TweenTransformClip))]
    public class TweenTransformTrack : TweenAnimationTrack<Transform, TweenTransformMixerBehaviour, TweenTransformBehaviour> { }
}