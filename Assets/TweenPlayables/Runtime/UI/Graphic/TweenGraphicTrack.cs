#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.UI;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Graphic))]
    [TrackClipType(typeof(TweenGraphicClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Tween Graphic Track")]
#endif
    public class TweenGraphicTrack : TweenAnimationTrack<Graphic, TweenGraphicMixerBehaviour, TweenGraphicBehaviour> { }
}