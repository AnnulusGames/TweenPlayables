using System;
using UnityEngine;
using UnityEngine.UI;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenTextBehaviour : TweenAnimationBehaviour<Text>
    {
        [SerializeField] ColorTweenParameter color;
        [SerializeField] IntTweenParameter fontSize;
        [SerializeField] FloatTweenParameter lineSpacing;
        [SerializeField] StringTweenParameter text;

        public ReadOnlyTweenParameter<Color> Color => color;
        public ReadOnlyTweenParameter<int> FontSize => fontSize;
        public ReadOnlyTweenParameter<float> LineSpacing => lineSpacing;
        public ReadOnlyTweenParameter<string> Text => text;

        public override void OnTweenInitialize(Text playerData)
        {
            color.SetInitialValue(playerData, playerData.color);
            fontSize.SetInitialValue(playerData, playerData.fontSize);
            lineSpacing.SetInitialValue(playerData, playerData.lineSpacing);
            text.SetInitialValue(playerData, playerData.text);
        }
    }
}