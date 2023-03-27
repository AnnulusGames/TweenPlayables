using System;
using UnityEngine;

namespace AnnulusGames.TweenPlayables
{
    [Serializable]
    public class TweenRendererBehaviour : TweenAnimationBehaviour<Renderer>
    {
        public ColorTweenParameter color;
        public Vector2TweenParameter textureOffset;
        public Vector2TweenParameter textureScale;

        public override void OnTweenInitialize(Renderer playerData)
        {
            color.SetInitialValue(playerData, playerData.sharedMaterial.color);
            textureOffset.SetInitialValue(playerData, playerData.sharedMaterial.mainTextureOffset);
            textureScale.SetInitialValue(playerData, playerData.sharedMaterial.mainTextureScale);
        }
    }

}