#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.UI;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(Text))]
    [TrackClipType(typeof(TweenTextClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Tween Text Track")]
#endif
    public sealed class TweenTextTrack : TweenAnimationTrack<Text, TweenTextMixerBehaviour, TweenTextBehaviour> { }
}