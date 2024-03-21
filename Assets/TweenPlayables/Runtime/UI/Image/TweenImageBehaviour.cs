using System;
using UnityEngine;
using UnityEngine.UI;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenImageBehaviour : TweenAnimationBehaviour<Image>
    {
        [SerializeField] ColorTweenParameter color;
        [SerializeField] FloatTweenParameter fillAmount;

        public ReadOnlyTweenParameter<Color> Color => color;
        public ReadOnlyTweenParameter<float> FillAmount => fillAmount;

        public override void OnTweenInitialize(Image playerData)
        {
            color.SetInitialValue(playerData, playerData.color);
            fillAmount.SetInitialValue(playerData, playerData.fillAmount);
        }
    }
}