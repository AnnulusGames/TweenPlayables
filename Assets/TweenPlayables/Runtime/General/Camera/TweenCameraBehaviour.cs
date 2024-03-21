using System;
using UnityEngine;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenCameraBehaviour : TweenAnimationBehaviour<Camera>
    {
        [SerializeField] FloatTweenParameter orthographicSize;
        [SerializeField] FloatTweenParameter fieldOfView;
        [SerializeField] ColorTweenParameter backgroundColor;

        public ReadOnlyTweenParameter<float> OrthographicSize => orthographicSize;
        public ReadOnlyTweenParameter<float> FieldOfView => fieldOfView;
        public ReadOnlyTweenParameter<Color> BackgroundColor => backgroundColor;

        public override void OnTweenInitialize(Camera playerData)
        {
            orthographicSize.SetInitialValue(playerData, playerData.orthographicSize);
            fieldOfView.SetInitialValue(playerData, playerData.fieldOfView);
            backgroundColor.SetInitialValue(playerData, playerData.backgroundColor);
        }
    }
}