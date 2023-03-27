using System;
using UnityEngine.UI;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public class TweenTextBehaviour : TweenAnimationBehaviour<Text>
    {
        public ColorTweenParameter color;
        public IntTweenParameter fontSize;
        public FloatTweenParameter lineSpacing;

        public override void OnTweenInitialize(Text playerData)
        {
            color.standardValue = playerData.color;
            fontSize.standardValue = playerData.fontSize;
            lineSpacing.standardValue = playerData.lineSpacing;
        }
    }

}