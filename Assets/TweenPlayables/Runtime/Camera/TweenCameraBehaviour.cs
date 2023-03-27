using System;
using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public class TweenCameraBehaviour : TweenAnimationBehaviour<Camera>
    {
        public FloatTweenParameter orthographicSize;
        public FloatTweenParameter fieldOfView;
        public ColorTweenParameter backgroundColor;

        public override void OnTweenInitialize(Camera playerData)
        {
            orthographicSize.standardValue = playerData.orthographicSize;
            fieldOfView.standardValue = playerData.fieldOfView;
            backgroundColor.standardValue = playerData.backgroundColor;
        }
    }

}