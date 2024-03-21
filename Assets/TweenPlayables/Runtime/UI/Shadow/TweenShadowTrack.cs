#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.UI;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(Shadow))]
    [TrackClipType(typeof(TweenShadowClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Shadow")]
#endif
    public sealed class TweenShadowTrack : TweenAnimationTrack<Shadow, TweenShadowMixerBehaviour, TweenShadowBehaviour> { }
}