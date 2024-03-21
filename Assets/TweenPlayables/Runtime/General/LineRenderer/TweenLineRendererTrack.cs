#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(LineRenderer))]
    [TrackClipType(typeof(TweenLineRendererClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/General/Line Renderer")]
#endif
    public sealed class TweenLineRendererTrack : TweenAnimationTrack<LineRenderer, TweenLineRendererMixerBehaviour, TweenLineRendererBehaviour> { }
}