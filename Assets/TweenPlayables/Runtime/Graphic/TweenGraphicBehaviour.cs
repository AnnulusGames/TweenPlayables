using System;
using UnityEngine.UI;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public class TweenGraphicBehaviour : TweenAnimationBehaviour<Graphic>
    {
        public ColorTweenParameter color;

        public override void OnTweenInitialize(Graphic playerData)
        {
            color.SetInitialValue(playerData, playerData.color);
        }
    }

}