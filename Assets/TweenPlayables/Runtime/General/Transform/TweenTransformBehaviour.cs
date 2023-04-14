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
            position.SetInitialValue(playerData, playerData.localPosition);
            rotation.SetInitialValue(playerData, playerData.localEulerAngles);
            scale.SetInitialValue(playerData, playerData.localScale);
        }
    }

}