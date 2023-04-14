#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.UI;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Slider))]
    [TrackClipType(typeof(TweenSliderClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Tween Slider Track")]
#endif
    public class TweenSliderTrack : TweenAnimationTrack<Slider, TweenSliderMixerBehaviour, TweenSliderBehaviour> { }
}