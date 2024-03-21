using System;
using UnityEngine;
using UnityEngine.UI;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenGraphicBehaviour : TweenAnimationBehaviour<Graphic>
    {
        [SerializeField] ColorTweenParameter color;

        public ReadOnlyTweenParameter<Color> Color => color;

        public override void OnTweenInitialize(Graphic playerData)
        {
            color.SetInitialValue(playerData, playerData.color);
        }
    }
}