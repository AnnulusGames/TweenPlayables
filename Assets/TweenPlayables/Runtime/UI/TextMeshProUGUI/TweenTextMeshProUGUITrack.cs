#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.Timeline;
using TMPro;
using System;

namespace TweenPlayables
{
    [Obsolete]
    [TrackBindingType(typeof(TextMeshProUGUI))]
    [TrackClipType(typeof(TweenTextMeshProUGUIClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/Legacy/TextMeshProUGUI")]
#endif
    public sealed class TweenTextMeshProUGUITrack : TweenAnimationTrack<TextMeshProUGUI, TweenTextMeshProUGUIMixerBehaviour, TweenTextMeshProUGUIBehaviour> { }
}