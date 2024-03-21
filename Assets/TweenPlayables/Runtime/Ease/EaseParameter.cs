using System;
using UnityEngine;

namespace TweenPlayables
{
    [Serializable]
    public sealed class EaseParameter
    {
        [SerializeField] Ease ease = Ease.Linear;
        [NormalizedAnimationCurve, SerializeField] AnimationCurve customEaseCurve = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);

        public EaseParameter() { }
        public EaseParameter(Ease ease)
        {
            SetEase(ease);
        }
        public EaseParameter(AnimationCurve curve)
        {
            SetEase(curve);
        }

        public void SetEase(Ease ease)
        {
            this.ease = ease;
        }

        public void SetEase(AnimationCurve curve)
        {
            ease = Ease.Custom;
            this.customEaseCurve = curve;
        }

        public float Evaluate(float time)
        {
            if (ease == Ease.Custom)
            {
                return customEaseCurve.Evaluate(time);
            }
            else
            {
                return EaseUtility.Evaluate(time, ease);
            }
        }
    }
}