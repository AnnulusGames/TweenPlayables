using System;
using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public class TweenLightBehaviour : TweenAnimationBehaviour<Light>
    {
        public ColorTweenParameter color;
        public FloatTweenParameter intensity;
        public FloatTweenParameter shadowStrength;

        public override void OnTweenInitialize(Light playerData)
        {
            color.standardValue = playerData.color;
            intensity.standardValue = playerData.intensity;
            shadowStrength.startValue = playerData.shadowStrength;
        }
    }

}