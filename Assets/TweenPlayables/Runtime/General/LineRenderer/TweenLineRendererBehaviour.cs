using System;
using UnityEngine;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenLineRendererBehaviour : TweenAnimationBehaviour<LineRenderer>
    {
        [SerializeField] ColorTweenParameter startColor;
        [SerializeField] ColorTweenParameter endColor;
        [SerializeField] FloatTweenParameter startWidth;
        [SerializeField] FloatTweenParameter endWidth;

        public ReadOnlyTweenParameter<Color> StartColor => startColor;
        public ReadOnlyTweenParameter<Color> EndColor => endColor;
        public ReadOnlyTweenParameter<float> StartWidth => startWidth;
        public ReadOnlyTweenParameter<float> EndWidth => endWidth;

        public override void OnTweenInitialize(LineRenderer playerData)
        {
            startColor.SetInitialValue(playerData, playerData.startColor);
            endColor.SetInitialValue(playerData, playerData.endColor);
            startWidth.SetInitialValue(playerData, playerData.startWidth);
            endWidth.SetInitialValue(playerData, playerData.endWidth);
        }
    }
}