using System;
using UnityEngine;
using UnityEngine.UI;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenShadowBehaviour : TweenAnimationBehaviour<Shadow>
    {
        [SerializeField] ColorTweenParameter color;
        [SerializeField] Vector3TweenParameter distance;

        public ReadOnlyTweenParameter<Color> Color => color;
        public ReadOnlyTweenParameter<Vector3> Distance => distance;

        public override void OnTweenInitialize(Shadow playerData)
        {
            color.SetInitialValue(playerData, playerData.effectColor);
            distance.SetInitialValue(playerData, playerData.effectDistance);
        }
    }
}