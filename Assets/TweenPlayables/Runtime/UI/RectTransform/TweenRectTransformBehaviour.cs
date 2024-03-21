using System;
using UnityEngine;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenRectTransformBehaviour : TweenAnimationBehaviour<RectTransform>
    {
        [SerializeField] Vector3TweenParameter anchoredPosition;
        [SerializeField] Vector2TweenParameter sizeDelta;
        [SerializeField] Vector3TweenParameter rotation;
        [SerializeField] Vector3TweenParameter scale;

        public ReadOnlyTweenParameter<Vector3> AnchoredPosition => anchoredPosition;
        public ReadOnlyTweenParameter<Vector2> SizeDelta => sizeDelta;
        public ReadOnlyTweenParameter<Vector3> Rotation => rotation;
        public ReadOnlyTweenParameter<Vector3> Scale => scale;

        public override void OnTweenInitialize(RectTransform playerData)
        {
            anchoredPosition.SetInitialValue(playerData, playerData.anchoredPosition3D);
            sizeDelta.SetInitialValue(playerData, playerData.sizeDelta);
            rotation.SetInitialValue(playerData, playerData.localEulerAngles);
            scale.SetInitialValue(playerData, playerData.localScale);
        }
    }
}