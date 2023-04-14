using System;
using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public class TweenCanvasGroupBehaviour : TweenAnimationBehaviour<CanvasGroup>
    {
        public FloatTweenParameter alpha;

        public override void OnTweenInitialize(CanvasGroup playerData)
        {
            alpha.SetInitialValue(playerData, playerData.alpha);
        }
    }

}