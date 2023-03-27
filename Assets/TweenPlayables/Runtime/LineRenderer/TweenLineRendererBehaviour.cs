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
            startColor.standardValue = playerData.startColor;
            endColor.standardValue = playerData.endColor;
            startWidth.standardValue = playerData.startWidth;
            endWidth.standardValue = playerData.endWidth;
        }
    }

}