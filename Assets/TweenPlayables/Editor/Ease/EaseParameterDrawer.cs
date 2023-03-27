using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomPropertyDrawer(typeof(EaseParameter))]
    public class EaseParameterDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.height = EditorGUIUtility.singleLineHeight;
            EditorGUI.BeginProperty(position, label, property);

            SerializedProperty easeProperty = property.FindPropertyRelative("ease");
            EditorGUI.PropertyField(position, easeProperty, label);

            if (((Ease)easeProperty.enumValueIndex) == Ease.Custom)
            {
                Rect rect = position;
                rect.y += EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
                rect.xMin += EditorGUIUtility.labelWidth + 2f;
                EditorGUI.PropertyField(rect, property.FindPropertyRelative("customEaseCurve"), GUIContent.none);
            }

            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            SerializedProperty easeProperty = property.FindPropertyRelative("ease");
            if (((Ease)easeProperty.enumValueIndex) == Ease.Custom) return EditorGUIUtility.singleLineHeight * 2 + EditorGUIUtility.standardVerticalSpacing;
            else return EditorGUIUtility.singleLineHeight;
        }
    }
}