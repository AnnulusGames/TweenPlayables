#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.UI;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(Graphic))]
    [TrackClipType(typeof(TweenGraphicClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Graphic")]
#endif
    public sealed class TweenGraphicTrack : TweenAnimationTrack<Graphic, TweenGraphicMixerBehaviour, TweenGraphicBehaviour> { }
}