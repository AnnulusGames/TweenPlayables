using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace TweenPlayables
{
    public abstract class ReadOnlyTweenParameter<T>
    {
        public virtual bool IsActive { get; }
        public abstract T Evaluate(object key, float t);
        public abstract T GetRelativeValue(object key, T value);
    }

    public abstract class TweenParameter<T> : ReadOnlyTweenParameter<T>
    {
        public TweenParameter() { }
        public TweenParameter(T startValue, T endValue)
        {
            this.startValue = startValue;
            this.endValue = endValue;
        }

        [SerializeField] bool active;
        [SerializeField] T startValue;
        [SerializeField] T endValue;
        [SerializeField] EaseParameter ease;
        [SerializeField] bool relative;

        public override bool IsActive => active;
        public T StartValue => startValue;
        public T EndValue => endValue;
        public EaseParameter EaseParameter => ease;
        public bool IsRelative => relative;

        [NonSerialized] readonly Dictionary<object, T> initialValueDictionary = new();

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
    }

    [Serializable]
    public sealed class Vector3TweenParameter : TweenParameter<Vector3>
    {
        public override Vector3 GetRelativeValue(object key, Vector3 value)
        {
            return GetInitialValue(key) + value;
        }

        public override Vector3 Evaluate(object key, float t)
        {
            if (IsRelative) return Vector3.LerpUnclamped(GetRelativeValue(key, StartValue), GetRelativeValue(key, EndValue), EaseParameter.Evaluate(t));
            else return Vector3.LerpUnclamped(StartValue, EndValue, EaseParameter.Evaluate(t));
        }
    }

    [Serializable]
    public sealed class Vector2TweenParameter : TweenParameter<Vector2>
    {
        public override Vector2 GetRelativeValue(object key, Vector2 value)
        {
            return GetInitialValue(key) + value;
        }

        public override Vector2 Evaluate(object key, float t)
        {
            if (IsRelative) return Vector2.LerpUnclamped(GetRelativeValue(key, StartValue), GetRelativeValue(key, EndValue), EaseParameter.Evaluate(t));
            else return Vector2.LerpUnclamped(StartValue, EndValue, EaseParameter.Evaluate(t));
        }
    }

    [Serializable]
    public sealed class ColorTweenParameter : TweenParameter<Color>
    {
        public ColorTweenParameter() : base(Color.white, Color.white) { }

        public override Color GetRelativeValue(object key, Color value)
        {
            return (GetInitialValue(key) + value) * 0.5f;
        }

        public override Color Evaluate(object key, float t)
        {
            if (IsRelative) return Color.LerpUnclamped(GetRelativeValue(key, StartValue), GetRelativeValue(key, EndValue), EaseParameter.Evaluate(t));
            else return Color.LerpUnclamped(StartValue, EndValue, EaseParameter.Evaluate(t));
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
            if (IsRelative) return Mathf.LerpUnclamped(GetRelativeValue(key, StartValue), GetRelativeValue(key, EndValue), EaseParameter.Evaluate(t));
            else return Mathf.LerpUnclamped(StartValue, EndValue, EaseParameter.Evaluate(t));
        }
    }

    [Serializable]
    public sealed class IntTweenParameter : TweenParameter<int>
    {
        public override int GetRelativeValue(object key, int value)
        {
            return GetInitialValue(key) + value;
        }

        public override int Evaluate(object key, float t)
        {
            if (IsRelative) return (int)Mathf.LerpUnclamped(GetRelativeValue(key, StartValue), GetRelativeValue(key, EndValue), EaseParameter.Evaluate(t));
            else return (int)Mathf.LerpUnclamped(StartValue, EndValue, EaseParameter.Evaluate(t));
        }
    }

    [Serializable]
    public sealed class StringTweenParameter : TweenParameter<string>
    {
        public ScrambleMode scrambleMode = ScrambleMode.None;
        public string customScrambleChars;

        public override string GetRelativeValue(object key, string value)
        {
            return value;
        }

        public override string Evaluate(object key, float t)
        {
            return StringTweenUtility.TweenText(StartValue, EndValue, t, scrambleMode, customScrambleChars);
        }
    }

    [Serializable]
    public sealed class VertexGradientTweenParamterer : TweenParameter<VertexGradient>
    {
        static readonly VertexGradient DefaultGradient = new()
        {
            topLeft = Color.white,
            topRight = Color.white,
            bottomLeft = Color.white,
            bottomRight = Color.white
        };

        public VertexGradientTweenParamterer() : base(DefaultGradient, DefaultGradient) { }

        public override VertexGradient GetRelativeValue(object key, VertexGradient value)
        {
            return new VertexGradient()
            {
                topLeft = StartValue.topLeft + value.topLeft,
                topRight = StartValue.topRight + value.topRight,
                bottomLeft = StartValue.bottomLeft + value.bottomLeft,
                bottomRight = StartValue.bottomRight + value.bottomRight
            };
        }

        public override VertexGradient Evaluate(object key, float t)
        {
            if (IsRelative)
            {
                var startValue = GetRelativeValue(key, StartValue);
                var endValue = GetRelativeValue(key, EndValue);
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
                    topLeft = Color.LerpUnclamped(StartValue.topLeft, EndValue.topLeft, t),
                    topRight = Color.LerpUnclamped(StartValue.topRight, EndValue.topRight, t),
                    bottomLeft = Color.LerpUnclamped(StartValue.bottomLeft, EndValue.bottomLeft, t),
                    bottomRight = Color.LerpUnclamped(StartValue.bottomLeft, EndValue.bottomLeft, t),
                };
            }
        }
    }
}
