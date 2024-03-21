#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.UI;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(Image))]
    [TrackClipType(typeof(TweenImageClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Image")]
#endif
    public sealed class TweenImageTrack : TweenAnimationTrack<Image, TweenImageMixerBehaviour, TweenImageBehaviour> { }
}