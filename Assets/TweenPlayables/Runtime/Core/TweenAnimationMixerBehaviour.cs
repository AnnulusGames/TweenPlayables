using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace TweenPlayables
{
    public abstract class TweenAnimationMixerBehaviour<TBinding, TAnimationBehaviour> : PlayableBehaviour
        where TBinding : Component
        where TAnimationBehaviour : TweenAnimationBehaviour<TBinding>, new()
    {
        TBinding target;
        readonly List<ScriptPlayable<TAnimationBehaviour>> playables = new();

        public override void OnPlayableDestroy(Playable playable)
        {
            playables.Clear();
            target = null;
        }

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {
            int inputCount = playable.GetInputCount();

            if (target == null)
            {
                target = playerData as TBinding;
                if (target == null) return;

                for (int i = 0; i < inputCount; i++)
                {
                    var instance = (ScriptPlayable<TAnimationBehaviour>)playable.GetInput(i);
                    playables.Add(instance);
                }

                foreach (var p in playables)
                {
                    p.GetBehaviour().Initialize(target);
                }
            }

            int activeInputCount = 0;
            TAnimationBehaviour lastBehaviour = null;
            for (int i = 0; i < inputCount; i++)
            {
                var inputPlayable = (ScriptPlayable<TAnimationBehaviour>)playable.GetInput(i);
                var behaviour = inputPlayable.GetBehaviour();
                var inputWeight = playable.GetInputWeight(i);
                var inputProgress = (float)(inputPlayable.GetTime() / inputPlayable.GetDuration());

                if (inputWeight == 0f)
                {
                    if (inputPlayable.GetPlayState() == PlayState.Paused && inputProgress > 0f)
                    {
                        lastBehaviour = behaviour;
                    }
                    continue;
                }

                Blend(target, behaviour, inputWeight, inputProgress);
                activeInputCount++;
            }

            if (activeInputCount == 0)
            {
                if (lastBehaviour != null)
                {
                    Blend(target, lastBehaviour, 1, 1);
                }
            }

            Apply(target);
        }

        public abstract void Blend(TBinding binding, TAnimationBehaviour behaviour, float weight, float progress);
        public abstract void Apply(TBinding binding);
    }
}
