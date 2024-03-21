using System;
using UnityEngine.UI;

namespace TweenPlayables
{
    [Serializable]
    public class TweenOutlineBehaviour : TweenAnimationBehaviour<Outline>
    {
        public ColorTweenParameter color;
        public Vector3TweenParameter distance;

        public override void OnTweenInitialize(Outline playerData)
        {
            color.SetInitialValue(playerData, playerData.effectColor);
            distance.SetInitialValue(playerData, playerData.effectDistance);
        }
    }

}