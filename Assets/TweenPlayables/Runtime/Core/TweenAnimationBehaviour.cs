using System;
using UnityEngine;
using UnityEngine.Playables;

namespace TweenPlayables
{
    [Serializable]
    public abstract class TweenAnimationBehaviour<TBinding> : PlayableBehaviour where TBinding : Component
    {
        bool initialized;

        public override void OnGraphStop(Playable playable)
        {
            initialized = false;
        }

        public override void OnBehaviourPause(Playable playable, FrameData info)
        {
            var duration = playable.GetDuration();
            var count = playable.GetTime() + info.deltaTime;

            if ((info.effectivePlayState == PlayState.Paused && count > duration) || playable.GetGraph().GetRootPlayable(0).IsDone())
            {
                OnTweenFinished();
            }
        }

        internal void Initialize(TBinding playerData)
        {
            if (playerData == null) return;
            if (initialized) return;
            
            OnTweenInitialize(playerData);
            initialized = true;
        }

        public virtual void OnTweenInitialize(TBinding playerData) { }
        public virtual void OnTweenFinished() { }
    }
}