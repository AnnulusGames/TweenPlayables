using System;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace TweenPlayables
{
    [Serializable]
    public abstract class TweenAnimationTrack<TBinding, TMixerBehaviour, TAnimationBehaviour> : TrackAsset
        where TBinding : Component
        where TAnimationBehaviour : TweenAnimationBehaviour<TBinding>, new()
        where TMixerBehaviour : TweenAnimationMixerBehaviour<TBinding, TAnimationBehaviour>, new()
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            var mixer = ScriptPlayable<TMixerBehaviour>.Create(graph, inputCount);
            return mixer;
        }

        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
#if UNITY_EDITOR
            var component = director.GetGenericBinding(this) as TBinding;
            if (component == null)
            {
                return;
            }

            var so = new SerializedObject(component);
            var iterator = so.GetIterator();
            while (iterator.NextVisible(true))
            {
                if (iterator.hasVisibleChildren)
                {
                    continue;
                }

                driver.AddFromName<TBinding>(component.gameObject, iterator.propertyPath);
            }
#endif
            base.GatherProperties(director, driver);
        }
    }
}
