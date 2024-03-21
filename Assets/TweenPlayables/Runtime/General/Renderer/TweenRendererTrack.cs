#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(Renderer))]
    [TrackClipType(typeof(TweenRendererClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/General/Renderer")]
#endif
    public sealed class TweenRendererTrack : TweenAnimationTrack<Renderer, TweenRendererMixerBehaviour, TweenRendererBehaviour> { }
}