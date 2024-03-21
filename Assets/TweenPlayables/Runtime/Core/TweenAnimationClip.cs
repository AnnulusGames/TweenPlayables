using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace TweenPlayables
{
    [Serializable]
    public abstract class TweenAnimationClip<TAnimationBehaviour> : PlayableAsset, ITimelineClipAsset
        where TAnimationBehaviour : PlayableBehaviour, new()
    {
        [SerializeField] TAnimationBehaviour behaviour = new();

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