#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.UI;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [TrackBindingType(typeof(Slider))]
    [TrackClipType(typeof(TweenSliderClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Slider")]
#endif
    public sealed class TweenSliderTrack : TweenAnimationTrack<Slider, TweenSliderMixerBehaviour, TweenSliderBehaviour> { }
}