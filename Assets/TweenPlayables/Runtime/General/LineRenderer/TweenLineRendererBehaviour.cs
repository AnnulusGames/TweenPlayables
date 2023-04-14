using System;
using System.Collections.Generic;
using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public class TweenLineRendererBehaviour : TweenAnimationBehaviour<LineRenderer>
    {
        public ColorTweenParameter startColor;
        public ColorTweenParameter endColor;
        public FloatTweenParameter startWidth;
        public FloatTweenParameter endWidth;

        public override void OnTweenInitialize(LineRenderer playerData)
        {
            startColor.SetInitialValue(playerData, playerData.startColor);
            endColor.SetInitialValue(playerData, playerData.endColor);
            startWidth.SetInitialValue(playerData, playerData.startWidth);
            endWidth.SetInitialValue(playerData, playerData.endWidth);
        }
    }

}