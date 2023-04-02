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

        private Dictionary<object, T> initialValueDictionary = new Dictionary<object, T>();

        public T GetInitialValue(object key)
        {
            initialValueDictionary.TryGetValue(key, out var value);
            return value;
        }

        public void SetInitialValue(object key, T value)
        {
            if (initialValueDictionary.ContainsKey(key))
            {
                initialValueDictionary[key] = value;
            }
            else
            {
                initialValueDictionary.TryAdd(key, value);
            }
        }

        public abstract T Evaluate(object key, float t);
        public abstract T GetRelativeValue(object key, T value);
    }

    [Serializable]
    public class Vector3TweenParameter : TweenParameter<Vector3>
    {
        public override Vector3 GetRelativeValue(object key, Vector3 value)
        {
            return GetInitialValue(key) + value;
        }

        public override Vector3 Evaluate(object key, float t)
        {
            if (relative) return Vector3.LerpUnclamped(GetRelativeValue(key, startValue), GetRelativeValue(key, endValue), ease.Evaluate(t));
            else return Vector3.LerpUnclamped(startValue, endValue, ease.Evaluate(t));
        }
    }

    [Serializable]
    public class Vector2TweenParameter : TweenParameter<Vector2>
    {
        public override Vector2 GetRelativeValue(object key, Vector2 value)
        {
            return GetInitialValue(key)  + value;
        }

        public override Vector2 Evaluate(object key, float t)
        {
            if (relative) return Vector2.LerpUnclamped(GetRelativeValue(key, startValue), GetRelativeValue(key, endValue), ease.Evaluate(t));
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

        public override Color GetRelativeValue(object key, Color value)
        {
            return (GetInitialValue(key) + value) * 0.5f;
        }

        public override Color Evaluate(object key, float t)
        {
            if (relative) return Color.LerpUnclamped(GetRelativeValue(key, startValue), GetRelativeValue(key, endValue), ease.Evaluate(t));
            else return Color.LerpUnclamped(startValue, endValue, ease.Evaluate(t));
        }
    }

    [Serializable]
    public class FloatTweenParameter : TweenParameter<float>
    {
        public override float GetRelativeValue(object key, float value)
        {
            return GetInitialValue(key) + value;
        }

        public override float Evaluate(object key, float t)
        {
            if (relative) return Mathf.LerpUnclamped(GetRelativeValue(key, startValue), GetRelativeValue(key, endValue), ease.Evaluate(t));
            else return Mathf.LerpUnclamped(startValue, endValue, ease.Evaluate(t));
        }
    }

    [Serializable]
    public class IntTweenParameter : TweenParameter<int>
    {
        public override int GetRelativeValue(object key, int value)
        {
            return GetInitialValue(key) + value;
        }

        public override int Evaluate(object key, float t)
        {
            if (relative) return (int)Mathf.LerpUnclamped(GetRelativeValue(key, startValue), GetRelativeValue(key, endValue), ease.Evaluate(t));
            else return (int)Mathf.LerpUnclamped(startValue, endValue, ease.Evaluate(t));
        }
    }

    [Serializable]
    public class StringTweenParameter : TweenParameter<string>
    {
        public ScrambleMode scrambleMode = ScrambleMode.None;
        public string customScrambleChars;

        public override string GetRelativeValue(object key, string value)
        {
            return value;
        }

        public override string Evaluate(object key, float t)
        {
            return StringTweenUtility.TweenText(startValue, endValue, t, scrambleMode, customScrambleChars);
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

        public override VertexGradient GetRelativeValue(object key, VertexGradient value)
        {
            return new VertexGradient()
            {
                topLeft = startValue.topLeft + value.topLeft,
                topRight = startValue.topRight + value.topRight,
                bottomLeft = startValue.bottomLeft + value.bottomLeft,
                bottomRight = startValue.bottomRight + value.bottomRight
            };
        }

        public override VertexGradient Evaluate(object key, float t)
        {
            if (relative)
            {
                var startValue = GetRelativeValue(key, this.startValue);
                var endValue = GetRelativeValue(key, this.endValue);
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
