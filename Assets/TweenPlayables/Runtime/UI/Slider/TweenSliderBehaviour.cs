using System;
using UnityEngine;
using UnityEngine.UI;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenSliderBehaviour : TweenAnimationBehaviour<Slider>
    {
        [SerializeField] FloatTweenParameter value;

        public ReadOnlyTweenParameter<float> Value => value;

        public override void OnTweenInitialize(Slider playerData)
        {
            value.SetInitialValue(playerData, playerData.value);
        }
    }
}