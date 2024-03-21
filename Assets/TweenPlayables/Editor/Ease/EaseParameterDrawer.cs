using UnityEngine;
using UnityEditor;

namespace TweenPlayables.Editor
{
    [CustomPropertyDrawer(typeof(EaseParameter))]
    public sealed class EaseParameterDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.height = EditorGUIUtility.singleLineHeight;
            EditorGUI.BeginProperty(position, label, property);

            var easeProperty = property.FindPropertyRelative("ease");
            EditorGUI.PropertyField(position, easeProperty, label);

            if (((Ease)easeProperty.enumValueIndex) == Ease.Custom)
            {
                var rect = position;
                rect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
                rect.xMin += EditorGUIUtility.labelWidth + 2f;
                EditorGUI.PropertyField(rect, property.FindPropertyRelative("customEaseCurve"), GUIContent.none);
            }

            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var easeProperty = property.FindPropertyRelative("ease");
            if (((Ease)easeProperty.enumValueIndex) == Ease.Custom) return EditorGUIUtility.singleLineHeight * 2 + EditorGUIUtility.standardVerticalSpacing;
            else return EditorGUIUtility.singleLineHeight;
        }
    }
}