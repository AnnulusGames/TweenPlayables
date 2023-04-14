#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.UI;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Shadow))]
    [TrackClipType(typeof(TweenShadowClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Tween Shadow Track")]
#endif
    public class TweenShadowTrack : TweenAnimationTrack<Shadow, TweenShadowMixerBehaviour, TweenShadowBehaviour> { }
}