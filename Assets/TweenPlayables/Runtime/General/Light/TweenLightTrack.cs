using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Light))]
    [TrackClipType(typeof(TweenLightClip))]
    public class TweenLightTrack : TweenAnimationTrack<Light, TweenLightMixerBehaviour, TweenLightBehaviour> { }
}