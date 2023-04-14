using UnityEngine.UI;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Image))]
    [TrackClipType(typeof(TweenImageClip))]
    public class TweenImageTrack : TweenAnimationTrack<Image, TweenImageMixerBehaviour, TweenImageBehaviour> { }
}