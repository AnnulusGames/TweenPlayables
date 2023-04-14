#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Camera))]
    [TrackClipType(typeof(TweenCameraClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/General/Tween Camera Track")]
#endif
    public class TweenCameraTrack : TweenAnimationTrack<Camera, TweenCameraMixerBehaviour, TweenCameraBehaviour> { }
}