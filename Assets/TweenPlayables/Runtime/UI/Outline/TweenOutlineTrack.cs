#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.UI;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(Outline))]
    [TrackClipType(typeof(TweenOutlineClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Outline")]
#endif
    public sealed class TweenOutlineTrack : TweenAnimationTrack<Outline, TweenOutlineMixerBehaviour, TweenOutlineBehaviour> { }
}