using UnityEngine;
using TMPro;

namespace AnnulusGames.TweenPlayables
{
    public abstract class ValueMixer<T>
    {
        public T Value { get; protected set; }
        public int ValueCount { get; protected set; }

        public void Blend(T value, float weight)
        {
            BlendInternal(value, weight);
            ValueCount++;
        }

        public virtual void Clear()
        {
            this.Value = default;
            ValueCount = 0;
        }

        protected abstract void BlendInternal(T value, float weight);
    }

    public class FloatValueMixer : ValueMixer<float>
    {
        protected override void BlendInternal(float value, float weight)
        {
            this.Value += value * weight;
        }
    }

    public class IntValueMixer : ValueMixer<int>
    {
        private float valueFloat;
        protected override void BlendInternal(int value, float weight)
        {
            this.valueFloat += value * weight;
            this.Value = (int)valueFloat;
        }

        public override void Clear()
        {
            base.Clear();
            valueFloat = 0f;
        }
    }

    public class ColorValueMixer : ValueMixer<Color>
    {
        protected override void BlendInternal(Color value, float weight)
        {
            this.Value += value * weight;
        }
    }

    public class Vector3ValueMixer : ValueMixer<Vector3>
    {
        protected override void BlendInternal(Vector3 value, float weight)
        {
            this.Value += value * weight;
        }
    }

    public class Vector2ValueMixer : ValueMixer<Vector2>
    {
        protected override void BlendInternal(Vector2 value, float weight)
        {
            this.Value += value * weight;
        }
    }

    public class VertexGradientValueMixer : ValueMixer<VertexGradient>
    {
        protected override void BlendInternal(VertexGradient value, float weight)
        {
            this.Value = new VertexGradient()
            {
                topLeft = this.Value.topLeft + value.topLeft * weight,
                topRight = this.Value.topRight + value.topRight * weight,
                bottomLeft = this.Value.bottomLeft + value.bottomLeft * weight,
                bottomRight = this.Value.bottomRight + value.bottomRight * weight
            };
        }
    }
}