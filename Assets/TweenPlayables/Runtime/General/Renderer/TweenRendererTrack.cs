#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Renderer))]
    [TrackClipType(typeof(TweenRendererClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/General/Tween Renderer Track")]
#endif
    public class TweenRendererTrack : TweenAnimationTrack<Renderer, TweenRendererMixerBehaviour, TweenRendererBehaviour> { }
}