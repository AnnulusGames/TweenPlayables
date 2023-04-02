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
        public StringTweenParameter text;

        public override void OnTweenInitialize(Text playerData)
        {
            color.SetInitialValue(playerData, playerData.color);
            fontSize.SetInitialValue(playerData, playerData.fontSize);
            lineSpacing.SetInitialValue(playerData, playerData.lineSpacing);
            text.SetInitialValue(playerData, playerData.text);
        }
    }

}