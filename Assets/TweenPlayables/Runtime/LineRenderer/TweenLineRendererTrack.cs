using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(LineRenderer))]
    [TrackClipType(typeof(TweenLineRendererClip))]
    public class TweenLineRendererTrack : TweenAnimationTrack<LineRenderer, TweenLineRendererMixerBehaviour, TweenLineRendererBehaviour> { }
}