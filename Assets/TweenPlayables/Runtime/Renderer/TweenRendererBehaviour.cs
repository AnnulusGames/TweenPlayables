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
            color.standardValue = playerData.sharedMaterial.color;
            textureOffset.standardValue = playerData.sharedMaterial.mainTextureOffset;
            textureScale.standardValue = playerData.sharedMaterial.mainTextureScale;
        }
    }

}