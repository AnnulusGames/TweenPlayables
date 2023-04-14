using UnityEngine.Timeline;
using TMPro;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(TextMeshProUGUI))]
    [TrackClipType(typeof(TweenTextMeshProUGUIClip))]
    public class TweenTextMeshProUGUITrack : TweenAnimationTrack<TextMeshProUGUI, TweenTextMeshProUGUIMixerBehaviour, TweenTextMeshProUGUIBehaviour> { }
}