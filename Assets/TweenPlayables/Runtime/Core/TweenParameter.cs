using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace AnnulusGames.TweenPlayables
{
    public abstract class TweenParameter<T>
    {
        public bool active;
        public T startValue;
        public T endValue;
        public EaseParameter ease;
        public bool relative;

        public T standardValue { get; set; }

        public abstract T Evaluate(float t);
        public abstract T GetRelativeValue(T value);
    }

    [Serializable]
    public class Vector3TweenParameter : TweenParameter<Vector3>
    {
        public override Vector3 GetRelativeValue(Vector3 value)
        {
            return standardValue + value;
        }

        public override Vector3 Evaluate(float t)
        {
            if (relative) return Vector3.LerpUnclamped(GetRelativeValue(startValue), GetRelativeValue(endValue), ease.Evaluate(t));
            else return Vector3.LerpUnclamped(startValue, endValue, ease.Evaluate(t));
        }
    }

    [Serializable]
    public class Vector2TweenParameter : TweenParameter<Vector2>
    {
        public override Vector2 GetRelativeValue(Vector2 value)
        {
            return standardValue + value;
        }

        public override Vector2 Evaluate(float t)
        {
            if (relative) return Vector2.LerpUnclamped(GetRelativeValue(startValue), GetRelativeValue(endValue), ease.Evaluate(t));
            else return Vector2.LerpUnclamped(startValue, endValue, ease.Evaluate(t));
        }
    }

    [Serializable]
    public class ColorTweenParameter : TweenParameter<Color>
    {
        public ColorTweenParameter()
        {
            startValue = Color.white;
            endValue = Color.white;
        }

        public override Color GetRelativeValue(Color value)
        {
            return (standardValue + value) * 0.5f;
        }

        public override Color Evaluate(float t)
        {
            if (relative) return Color.LerpUnclamped(GetRelativeValue(startValue), GetRelativeValue(endValue), ease.Evaluate(t));
            else return Color.LerpUnclamped(startValue, endValue, ease.Evaluate(t));
        }
    }

    [Serializable]
    public class FloatTweenParameter : TweenParameter<float>
    {
        public override float GetRelativeValue(float value)
        {
            return standardValue + value;
        }

        public override float Evaluate(float t)
        {
            if (relative) return Mathf.LerpUnclamped(GetRelativeValue(startValue), GetRelativeValue(endValue), ease.Evaluate(t));
            else return Mathf.LerpUnclamped(startValue, endValue, ease.Evaluate(t));
        }
    }

    [Serializable]
    public class IntTweenParameter : TweenParameter<int>
    {
        public override int GetRelativeValue(int value)
        {
            return standardValue + value;
        }

        public override int Evaluate(float t)
        {
            if (relative) return (int)Mathf.LerpUnclamped(GetRelativeValue(startValue), GetRelativeValue(endValue), ease.Evaluate(t));
            else return (int)Mathf.LerpUnclamped(startValue, endValue, ease.Evaluate(t));
        }
    }

    [Serializable]
    public class VertexGradientTweenParamterer : TweenParameter<VertexGradient>
    {
        public VertexGradientTweenParamterer()
        {
            startValue = new VertexGradient()
            {
                topLeft = Color.white,
                topRight = Color.white,
                bottomLeft = Color.white,
                bottomRight = Color.white
            };
            endValue = new VertexGradient()
            {
                topLeft = Color.white,
                topRight = Color.white,
                bottomLeft = Color.white,
                bottomRight = Color.white
            };
        }

        public override VertexGradient GetRelativeValue(VertexGradient value)
        {
            return new VertexGradient()
            {
                topLeft = startValue.topLeft + value.topLeft,
                topRight = startValue.topRight + value.topRight,
                bottomLeft = startValue.bottomLeft + value.bottomLeft,
                bottomRight = startValue.bottomRight + value.bottomRight
            };
        }

        public override VertexGradient Evaluate(float t)
        {
            if (relative)
            {
                var startValue = GetRelativeValue(this.startValue);
                var endValue = GetRelativeValue(this.endValue);
                return new VertexGradient()
                {
                    topLeft = Color.LerpUnclamped(startValue.topLeft, endValue.topLeft, t),
                    topRight = Color.LerpUnclamped(startValue.topRight, endValue.topRight, t),
                    bottomLeft = Color.LerpUnclamped(startValue.bottomLeft, endValue.bottomLeft, t),
                    bottomRight = Color.LerpUnclamped(startValue.bottomLeft, endValue.bottomLeft, t),
                };
            }
            else
            {
                return new VertexGradient()
                {
                    topLeft = Color.LerpUnclamped(startValue.topLeft, endValue.topLeft, t),
                    topRight = Color.LerpUnclamped(startValue.topRight, endValue.topRight, t),
                    bottomLeft = Color.LerpUnclamped(startValue.bottomLeft, endValue.bottomLeft, t),
                    bottomRight = Color.LerpUnclamped(startValue.bottomLeft, endValue.bottomLeft, t),
                };
            }
        }
    }
}
