using System;
using UnityEngine.UI;

namespace TweenPlayables
{
    [Serializable]
    public class TweenSliderBehaviour : TweenAnimationBehaviour<Slider>
    {
        public FloatTweenParameter value;

        public override void OnTweenInitialize(Slider playerData)
        {
            value.SetInitialValue(playerData, playerData.value);
        }
    }

}