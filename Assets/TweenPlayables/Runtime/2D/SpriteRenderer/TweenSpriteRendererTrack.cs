using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(SpriteRenderer))]
    [TrackClipType(typeof(TweenSpriteRendererClip))]
    public class TweenSpriteRendererTrack : TweenAnimationTrack<SpriteRenderer, TweenSpriteRendererMixerBehaviour, TweenSpriteRendererBehaviour> { }
}