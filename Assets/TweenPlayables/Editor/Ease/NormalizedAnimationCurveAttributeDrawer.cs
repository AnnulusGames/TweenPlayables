using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomPropertyDrawer(typeof(NormalizedAnimationCurveAttribute))]
    public class NormalizedAnimationCurveAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var attr = (NormalizedAnimationCurveAttribute)attribute;

            if (property.propertyType != SerializedPropertyType.AnimationCurve)
            {
                position = EditorGUI.PrefixLabel(position, label);
                var preIndent = EditorGUI.indentLevel;
                EditorGUI.indentLevel = 0;
                EditorGUI.LabelField(position, "Use NormalizedAnimationCurveAttribute with AnimationCurve.");
                EditorGUI.indentLevel = preIndent;
                return;
            }

            using (var ccs = new EditorGUI.ChangeCheckScope())
            {
                EditorGUI.PropertyField(position, property, label, true);
                if (ccs.changed)
                {
                    property.animationCurveValue = NormalizeTime(property.animationCurveValue);
                }
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property);
        }

        private static AnimationCurve NormalizeTime(AnimationCurve curve)
        {
            var keys = curve.keys;
            if (keys.Length <= 0)
            {
                return curve;
            }

            var minTime = keys[0].time;
            var maxTime = minTime;
            foreach (var t in keys)
            {
                minTime = Mathf.Min(minTime, t.time);
                maxTime = Mathf.Max(maxTime, t.time);
            }

            var range = maxTime - minTime;
            var timeScale = range < 0.0001f ? 1 : 1 / range;
            for (var i = 0; i < keys.Length; ++i)
            {
                keys[i].time = (keys[i].time - minTime) * timeScale;
            }

            curve.keys = keys;
            return curve;
        }
    }
}