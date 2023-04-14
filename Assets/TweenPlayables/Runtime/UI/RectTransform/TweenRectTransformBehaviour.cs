using System;
using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public class TweenRectTransformBehaviour : TweenAnimationBehaviour<RectTransform>
    {
        public Vector3TweenParameter anchoredPosition;
        public Vector2TweenParameter sizeDelta;
        public Vector3TweenParameter rotation;
        public Vector3TweenParameter scale;

        public override void OnTweenInitialize(RectTransform playerData)
        {
            anchoredPosition.SetInitialValue(playerData, playerData.anchoredPosition3D);
            sizeDelta.SetInitialValue(playerData, playerData.sizeDelta);
            rotation.SetInitialValue(playerData, playerData.localEulerAngles);
            scale.SetInitialValue(playerData, playerData.localScale);
        }
    }

}