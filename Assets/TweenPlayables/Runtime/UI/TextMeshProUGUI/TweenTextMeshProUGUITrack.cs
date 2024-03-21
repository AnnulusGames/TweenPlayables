#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.Timeline;
using TMPro;

namespace TweenPlayables
{
    [TrackBindingType(typeof(TextMeshProUGUI))]
    [TrackClipType(typeof(TweenTextMeshProUGUIClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/TextMeshPro UGUI")]
#endif
    public sealed class TweenTextMeshProUGUITrack : TweenAnimationTrack<TextMeshProUGUI, TweenTextMeshProUGUIMixerBehaviour, TweenTextMeshProUGUIBehaviour> { }
}