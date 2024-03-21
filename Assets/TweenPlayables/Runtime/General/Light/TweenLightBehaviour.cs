using System;
using UnityEngine;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenLightBehaviour : TweenAnimationBehaviour<Light>
    {
        [SerializeField] ColorTweenParameter color;
        [SerializeField] FloatTweenParameter intensity;
        [SerializeField] FloatTweenParameter shadowStrength;

        public ReadOnlyTweenParameter<Color> Color => color;
        public ReadOnlyTweenParameter<float> Intensity => intensity;
        public ReadOnlyTweenParameter<float> ShadowStrength => shadowStrength;

        public override void OnTweenInitialize(Light playerData)
        {
            color.SetInitialValue(playerData, playerData.color);
            intensity.SetInitialValue(playerData, playerData.intensity);
            shadowStrength.SetInitialValue(playerData, playerData.shadowStrength);
        }
    }
}