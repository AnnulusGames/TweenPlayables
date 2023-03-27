using System;
using UnityEngine.UI;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public class TweenImageBehaviour : TweenAnimationBehaviour<Image>
    {
        public ColorTweenParameter color;
        public FloatTweenParameter fillAmount;

        public override void OnTweenInitialize(Image playerData)
        {
            color.standardValue = playerData.color;
            fillAmount.standardValue = playerData.fillAmount;
        }
    }

}