#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.Timeline;
using TMPro;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(TextMeshProUGUI))]
    [TrackClipType(typeof(TweenTextMeshProUGUIClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Tween TextMeshProUGUI Track")]
#endif
    public class TweenTextMeshProUGUITrack : TweenAnimationTrack<TextMeshProUGUI, TweenTextMeshProUGUIMixerBehaviour, TweenTextMeshProUGUIBehaviour> { }
}