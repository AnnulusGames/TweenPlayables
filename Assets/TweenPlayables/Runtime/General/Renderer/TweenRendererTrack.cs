using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Renderer))]
    [TrackClipType(typeof(TweenRendererClip))]
    public class TweenRendererTrack : TweenAnimationTrack<Renderer, TweenRendererMixerBehaviour, TweenRendererBehaviour> { }
}