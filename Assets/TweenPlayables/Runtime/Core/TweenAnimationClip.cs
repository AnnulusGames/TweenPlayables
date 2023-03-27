using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public abstract class TweenAnimationClip<TAnimationBehaviour> : PlayableAsset, ITimelineClipAsset
        where TAnimationBehaviour : PlayableBehaviour, new()
    {
        public TAnimationBehaviour behaviour = new TAnimationBehaviour();

        public ClipCaps clipCaps
        {
            get
            {
                return ClipCaps.Blending;
            }
        }

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<TAnimationBehaviour>.Create(graph, behaviour);
            return playable;
        }
    }
}