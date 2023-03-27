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
            anchoredPosition.standardValue = playerData.anchoredPosition3D;
            sizeDelta.standardValue = playerData.sizeDelta;
            rotation.standardValue = playerData.localEulerAngles;
            scale.standardValue = playerData.localScale;
        }
    }

}