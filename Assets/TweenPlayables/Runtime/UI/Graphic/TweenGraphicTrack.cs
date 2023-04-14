using UnityEngine.UI;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Graphic))]
    [TrackClipType(typeof(TweenGraphicClip))]
    public class TweenGraphicTrack : TweenAnimationTrack<Graphic, TweenGraphicMixerBehaviour, TweenGraphicBehaviour> { }
}