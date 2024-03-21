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
    [DisplayName("Tween Playables/UI/Text")]
#endif
    public sealed class TweenTextTrack : TweenAnimationTrack<Text, TweenTextMixerBehaviour, TweenTextBehaviour> { }
}