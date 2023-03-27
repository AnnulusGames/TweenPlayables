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

        public override void OnTweenInitialize(TextMeshProUGUI playerData)
        {
            color.standardValue = playerData.color;
            fontSize.standardValue = playerData.fontSize;
            wordSpacing.standardValue = playerData.wordSpacing;
            lineSpacing.standardValue = playerData.lineSpacing;
            characterSpacing.standardValue = playerData.characterSpacing;
            paragraphSpacing.standardValue = playerData.paragraphSpacing;
            colorGradient.standardValue = playerData.colorGradient;
        }
    }

}