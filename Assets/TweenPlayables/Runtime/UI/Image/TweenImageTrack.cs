#if UNITY_EDITOR
using System.ComponentModel;
#endif
using UnityEngine.UI;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Image))]
    [TrackClipType(typeof(TweenImageClip))]
#if UNITY_EDITOR
    [DisplayName("Tween Playables/UI/Tween Image Track")]
#endif
    public class TweenImageTrack : TweenAnimationTrack<Image, TweenImageMixerBehaviour, TweenImageBehaviour> { }
}