#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.Timeline;
using TMPro;

namespace TweenPlayables
{
    [TrackBindingType(typeof(TMP_Text))]
    [TrackClipType(typeof(TweenTMPTextClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/TMP_Text")]
#endif
    public sealed class TweenTMPTextTrack : TweenAnimationTrack<TMP_Text, TweenTMPTextMixerBehaviour, TweenTMPTextBehaviour> { }
}