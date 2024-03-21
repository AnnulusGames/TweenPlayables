using System;
using UnityEngine;

namespace TweenPlayables
{
    [Serializable]
    public sealed class TweenRendererBehaviour : TweenAnimationBehaviour<Renderer>
    {
        [SerializeField] ColorTweenParameter color;
        [SerializeField] Vector2TweenParameter textureOffset;
        [SerializeField] Vector2TweenParameter textureScale;

        public ReadOnlyTweenParameter<Color> Color => color;
        public ReadOnlyTweenParameter<Vector2> TextureOffset => textureOffset;
        public ReadOnlyTweenParameter<Vector2> TextureScale => textureScale;

        public override void OnTweenInitialize(Renderer playerData)
        {
            color.SetInitialValue(playerData, playerData.sharedMaterial.color);
            textureOffset.SetInitialValue(playerData, playerData.sharedMaterial.mainTextureOffset);
            textureScale.SetInitialValue(playerData, playerData.sharedMaterial.mainTextureScale);
        }
    }
}