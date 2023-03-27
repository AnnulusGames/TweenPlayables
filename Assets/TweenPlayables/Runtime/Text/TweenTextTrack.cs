using UnityEngine.UI;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Text))]
    [TrackClipType(typeof(TweenTextClip))]
    public class TweenTextTrack : TweenAnimationTrack<Text, TweenTextMixerBehaviour, TweenTextBehaviour> { }
}