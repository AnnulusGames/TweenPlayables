using UnityEngine.UI;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Slider))]
    [TrackClipType(typeof(TweenSliderClip))]
    public class TweenSliderTrack : TweenAnimationTrack<Slider, TweenSliderMixerBehaviour, TweenSliderBehaviour> { }
}