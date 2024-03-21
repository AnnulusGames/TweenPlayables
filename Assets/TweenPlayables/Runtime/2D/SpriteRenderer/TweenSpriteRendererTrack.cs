#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(SpriteRenderer))]
    [TrackClipType(typeof(TweenSpriteRendererClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/2D/Sprite Renderer")]
#endif
    public sealed class TweenSpriteRendererTrack : TweenAnimationTrack<SpriteRenderer, TweenSpriteRendererMixerBehaviour, TweenSpriteRendererBehaviour> { }
}