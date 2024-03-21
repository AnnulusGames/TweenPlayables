using System;
using UnityEngine;
using TMPro;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenTMPTextBehaviour : TweenAnimationBehaviour<TMP_Text>
    {
        [SerializeField] ColorTweenParameter color;
        [SerializeField] FloatTweenParameter fontSize;
        [SerializeField] FloatTweenParameter characterSpacing;
        [SerializeField] FloatTweenParameter wordSpacing;
        [SerializeField] FloatTweenParameter lineSpacing;
        [SerializeField] FloatTweenParameter paragraphSpacing;
        [SerializeField] VertexGradientTweenParamterer colorGradient;
        [SerializeField] StringTweenParameter text;

        public ReadOnlyTweenParameter<Color> Color => color;
        public ReadOnlyTweenParameter<float> FontSize => fontSize;
        public ReadOnlyTweenParameter<float> CharacterSpacing => characterSpacing;
        public ReadOnlyTweenParameter<float> WordSpacing => wordSpacing;
        public ReadOnlyTweenParameter<float> LineSpacing => lineSpacing;
        public ReadOnlyTweenParameter<float> ParagraphSpacing => paragraphSpacing;
        public ReadOnlyTweenParameter<VertexGradient> ColorGradient => colorGradient;
        public ReadOnlyTweenParameter<string> Text => text;

        public override void OnTweenInitialize(TMP_Text playerData)
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