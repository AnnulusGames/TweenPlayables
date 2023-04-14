using System;
using UnityEngine.UI;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public class TweenShadowBehaviour : TweenAnimationBehaviour<Shadow>
    {
        public ColorTweenParameter color;
        public Vector3TweenParameter distance;

        public override void OnTweenInitialize(Shadow playerData)
        {
            color.SetInitialValue(playerData, playerData.effectColor);
            distance.SetInitialValue(playerData, playerData.effectDistance);
        }
    }

}