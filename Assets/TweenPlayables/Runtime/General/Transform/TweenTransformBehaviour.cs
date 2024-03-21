using System;
using UnityEngine;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenTransformBehaviour : TweenAnimationBehaviour<Transform>
    {
        [SerializeField] Vector3TweenParameter position;
        [SerializeField] Vector3TweenParameter rotation;
        [SerializeField] Vector3TweenParameter scale;

        public ReadOnlyTweenParameter<Vector3> Position => position;
        public ReadOnlyTweenParameter<Vector3> Rotation => rotation;
        public ReadOnlyTweenParameter<Vector3> Scale => scale;

        public override void OnTweenInitialize(Transform playerData)
        {
            position.SetInitialValue(playerData, playerData.localPosition);
            rotation.SetInitialValue(playerData, playerData.localEulerAngles);
            scale.SetInitialValue(playerData, playerData.localScale);
        }
    }
}