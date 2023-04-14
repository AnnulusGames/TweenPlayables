#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(SpriteRenderer))]
    [TrackClipType(typeof(TweenSpriteRendererClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/2D/Tween SpriteRenderer Track")]
#endif
    public class TweenSpriteRendererTrack : TweenAnimationTrack<SpriteRenderer, TweenSpriteRendererMixerBehaviour, TweenSpriteRendererBehaviour> { }
}