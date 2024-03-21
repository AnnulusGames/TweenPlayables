using System;

namespace TweenPlayables
{
    public static class EaseUtility
    {
        static readonly float PI = MathF.PI;

        public static float Evaluate(float t, Ease ease)
        {
            switch (ease)
            {
                default:
                case Ease.Linear:
                    return t;
                case Ease.InSine:
                    return 1 - MathF.Cos((t * PI) * 0.5f);
                case Ease.OutSine:
                    return MathF.Sin((t * PI) * 0.5f);
                case Ease.InOutSine:
                    return -(MathF.Cos(t * PI) - 1) * 0.5f;
                case Ease.InQuad:
                    return t * t;
                case Ease.OutQuad:
                    return 1 - (1 - t) * (1 - t);
                case Ease.InOutQuad:
                    return t < 0.5f
                        ? 2 * t * t
                        : 1 - (MathF.Pow(-2 * t + 2, 2) * 0.5f);
                case Ease.InCubic:
                    return t * t * t;
                case Ease.OutCubic:
                    return 1 - MathF.Pow(1 - t, 3);
                case Ease.InOutCubic:
                    return t < 0.5f
                        ? 4 * t * t * t
                        : 1 - MathF.Pow(-2 * t + 2, 3) * 0.5f;
                case Ease.InQuart:
                    return t * t * t * t;
                case Ease.OutQuart:
                    return 1 - MathF.Pow(1 - t, 4);
                case Ease.InOutQuart:
                    return t < 0.5f
                        ? 8 * t * t * t * t
                        : 1 - MathF.Pow(-2 * t + 2, 4) * 0.5f;
                case Ease.InQuint:
                    return t * t * t * t * t;
                case Ease.OutQuint:
                    return 1 - MathF.Pow(1 - t, 5);
                case Ease.InOutQuint:
                    return t < 0.5f
                        ? 16 * t * t * t * t * t
                        : 1 - MathF.Pow(-2 * t + 2, 5) * 0.5f;
                case Ease.InExpo:
                    return t == 0
                        ? 0
                        : MathF.Pow(2, 10 * (t - 1));
                case Ease.OutExpo:
                    return t == 1
                            ? 1
                            : -MathF.Pow(2, -10 * t) + 1;
                case Ease.InOutExpo:
                    if (t == 0) return 0;
                    if (t == 1) return 1;
                    return t < 0.5f
                        ? MathF.Pow(2, 20 * t - 10) * 0.5f
                        : (2 - MathF.Pow(2, -20 * t + 10)) * 0.5f;
                case Ease.InCirc:
                    return 1 - MathF.Sqrt(1 - MathF.Pow(t, 2));
                case Ease.OutCirc:
                    return MathF.Sqrt(1 - MathF.Pow(t - 1, 2));
                case Ease.InOutCirc:
                    return t < 0.5f
                        ? (1 - MathF.Sqrt(1 - MathF.Pow(2 * t, 2))) * 0.5f
                        : (MathF.Sqrt(1 - MathF.Pow(-2 * t + 2, 2)) + 1) * 0.5f;
                case Ease.InElastic:
                    if (t == 0) return 0;
                    if (t == 1) return 1;
                    return -MathF.Sin(7.5f * PI * t) * MathF.Pow(2, 10 * (t - 1));
                case Ease.OutElastic:
                    if (t == 0) return 0;
                    if (t == 1) return 1;
                    return MathF.Sin(-7.5f * PI * (t + 1)) * MathF.Pow(2, -10 * t) + 1;
                case Ease.InOutElastic:
                    if (t == 0) return 0;
                    if (t == 1) return 1;
                    return t < 0.5f
                        ? 0.5f * MathF.Sin(7.5f * PI * (2 * t)) * MathF.Pow(2, 10 * (2 * t - 1))
                        : 0.5f * (MathF.Sin(-7.5f * PI * (2 * t - 1 + 1)) * MathF.Pow(2, -10 * (2 * t - 1)) + 2);
                case Ease.InBack:
                    return t * t * t - t * MathF.Sin(t * PI);
                case Ease.OutBack:
                    return 1 - (MathF.Pow(1 - t, 3) - (1 - t) * MathF.Sin((1 - t) * PI));
                case Ease.InOutBack:
                    if (t < 0.5f)
                    {
                        float f = 2 * t;
                        return 0.5f * (f * f * f - f * MathF.Sin(f * PI));
                    }
                    else
                    {
                        float f = 1 - (2 * t - 1);
                        return 0.5f * (1 - (f * f * f - f * MathF.Sin(f * PI))) + 0.5f;
                    }
                case Ease.InBounce:
                    return 1 - Evaluate(1 - t, Ease.OutBounce);
                case Ease.OutBounce:
                    if (t < 1 / 2.75f)
                    {
                        return 7.5625f * t * t;
                    }
                    else if (t < 2 / 2.75f)
                    {
                        return 7.5625f * (t -= 1.5f / 2.75f) * t + 0.75f;
                    }
                    else if (t < 2.5 / 2.75f)
                    {
                        return 7.5625f * (t -= 2.25f / 2.75f) * t + 0.9375f;
                    }
                    else
                    {
                        return 7.5625f * (t -= 2.625f / 2.75f) * t + 0.984375f;
                    }
                case Ease.InOutBounce:
                    return t < 0.5f
                        ? (1 - Evaluate(1 - 2 * t, Ease.InBounce)) * 0.5f
                        : (1 + Evaluate(2 * t - 1, Ease.OutBounce)) * 0.5f;
                case Ease.Custom:
                    return 1;
            }
        }

    }

}