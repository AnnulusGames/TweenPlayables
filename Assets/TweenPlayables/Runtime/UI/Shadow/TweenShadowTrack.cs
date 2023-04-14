using UnityEngine.UI;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Shadow))]
    [TrackClipType(typeof(TweenShadowClip))]
    public class TweenShadowTrack : TweenAnimationTrack<Shadow, TweenShadowMixerBehaviour, TweenShadowBehaviour> { }
}