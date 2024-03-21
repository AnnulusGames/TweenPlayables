using System;
using UnityEngine;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenCanvasGroupBehaviour : TweenAnimationBehaviour<CanvasGroup>
    {
        [SerializeField] FloatTweenParameter alpha;

        public ReadOnlyTweenParameter<float> Alpha => alpha;

        public override void OnTweenInitialize(CanvasGroup playerData)
        {
            alpha.SetInitialValue(playerData, playerData.alpha);
        }
    }
}