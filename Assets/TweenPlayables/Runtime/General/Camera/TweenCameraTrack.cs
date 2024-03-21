#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(Camera))]
    [TrackClipType(typeof(TweenCameraClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/General/Camera")]
#endif
    public sealed class TweenCameraTrack : TweenAnimationTrack<Camera, TweenCameraMixerBehaviour, TweenCameraBehaviour> { }
}