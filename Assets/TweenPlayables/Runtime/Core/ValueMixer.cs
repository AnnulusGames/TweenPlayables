using UnityEngine;
using TMPro;

namespace TweenPlayables
{
    public abstract class ValueMixer<T>
    {
        public T Value { get; protected set; }
        public bool HasValue => count > 0;
        int count;

        public void Blend(T value, float weight)
        {
            BlendCore(value, weight);
            count++;
        }

        public virtual void Clear()
        {
            Value = default;
            count = 0;
        }

        protected abstract void BlendCore(T value, float weight);
    }

    public sealed class FloatValueMixer : ValueMixer<float>
    {
        protected override void BlendCore(float value, float weight)
        {
            Value += value * weight;
        }
    }

    public sealed class IntValueMixer : ValueMixer<int>
    {
        float valueFloat;

        protected override void BlendCore(int value, float weight)
        {
            valueFloat += value * weight;
            Value = (int)valueFloat;
        }

        public override void Clear()
        {
            base.Clear();
            valueFloat = 0f;
        }
    }

    public sealed class ColorValueMixer : ValueMixer<Color>
    {
        protected override void BlendCore(Color value, float weight)
        {
            Value += value * weight;
        }
    }

    public sealed class Vector3ValueMixer : ValueMixer<Vector3>
    {
        protected override void BlendCore(Vector3 value, float weight)
        {
            Value += value * weight;
        }
    }

    public sealed class Vector2ValueMixer : ValueMixer<Vector2>
    {
        protected override void BlendCore(Vector2 value, float weight)
        {
            Value += value * weight;
        }
    }

    public sealed class VertexGradientValueMixer : ValueMixer<VertexGradient>
    {
        protected override void BlendCore(VertexGradient value, float weight)
        {
            Value = new VertexGradient()
            {
                topLeft = Value.topLeft + value.topLeft * weight,
                topRight = Value.topRight + value.topRight * weight,
                bottomLeft = Value.bottomLeft + value.bottomLeft * weight,
                bottomRight = Value.bottomRight + value.bottomRight * weight
            };
        }
    }
}