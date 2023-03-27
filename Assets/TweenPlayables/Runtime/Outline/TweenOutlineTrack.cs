using UnityEngine.UI;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [TrackBindingType(typeof(Outline))]
    [TrackClipType(typeof(TweenOutlineClip))]
    public class TweenOutlineTrack : TweenAnimationTrack<Outline, TweenOutlineMixerBehaviour, TweenOutlineBehaviour> { }
}