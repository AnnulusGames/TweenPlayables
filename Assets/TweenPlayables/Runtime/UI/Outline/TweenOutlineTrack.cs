#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.UI;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Outline))]
    [TrackClipType(typeof(TweenOutlineClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Tween Outline Track")]
#endif
    public class TweenOutlineTrack : TweenAnimationTrack<Outline, TweenOutlineMixerBehaviour, TweenOutlineBehaviour> { }
}