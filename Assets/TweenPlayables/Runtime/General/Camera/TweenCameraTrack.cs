using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Camera))]
    [TrackClipType(typeof(TweenCameraClip))]
    public class TweenCameraTrack : TweenAnimationTrack<Camera, TweenCameraMixerBehaviour, TweenCameraBehaviour> { }
}