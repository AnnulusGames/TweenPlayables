using System;
using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public class TweenTransformBehaviour : TweenAnimationBehaviour<Transform>
    {
        public Vector3TweenParameter position;
        public Vector3TweenParameter rotation;
        public Vector3TweenParameter scale;

        public override void OnTweenInitialize(Transform playerData)
        {
            position.standardValue = playerData.localPosition;
            rotation.standardValue = playerData.localEulerAngles;
            scale.standardValue = playerData.localScale;
        }
    }

}