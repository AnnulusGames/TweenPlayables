#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(LineRenderer))]
    [TrackClipType(typeof(TweenLineRendererClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/General/Tween LineRenderer Track")]
#endif
    public class TweenLineRendererTrack : TweenAnimationTrack<LineRenderer, TweenLineRendererMixerBehaviour, TweenLineRendererBehaviour> { }
}