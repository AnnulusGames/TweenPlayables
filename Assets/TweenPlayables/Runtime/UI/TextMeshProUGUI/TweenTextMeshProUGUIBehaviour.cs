using System;
using UnityEngine.UI;
using TMPro;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public class TweenTextMeshProUGUIBehaviour : TweenAnimationBehaviour<TextMeshProUGUI>
    {
        public ColorTweenParameter color;
        public FloatTweenParameter fontSize;
        public FloatTweenParameter characterSpacing;
        public FloatTweenParameter wordSpacing;
        public FloatTweenParameter lineSpacing;
        public FloatTweenParameter paragraphSpacing;
        public VertexGradientTweenParamterer colorGradient;
        public StringTweenParameter text;

        public override void OnTweenInitialize(TextMeshProUGUI playerData)
        {
            color.SetInitialValue(playerData, playerData.color);
            fontSize.SetInitialValue(playerData, playerData.fontSize);
            wordSpacing.SetInitialValue(playerData, playerData.wordSpacing);
            lineSpacing.SetInitialValue(playerData, playerData.lineSpacing);
            characterSpacing.SetInitialValue(playerData, playerData.characterSpacing);
            paragraphSpacing.SetInitialValue(playerData, playerData.paragraphSpacing);
            colorGradient.SetInitialValue(playerData, playerData.colorGradient);
            text.SetInitialValue(playerData, playerData.text);
        }
    }

}