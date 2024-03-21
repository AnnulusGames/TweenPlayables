using UnityEngine;
using UnityEditor;

namespace TweenPlayables.Editor
{
    public static class GUIHelper
    {
        public static void Field(ref Rect position, SerializedProperty property)
        {
            position.height = EditorGUI.GetPropertyHeight(property);
            EditorGUI.PropertyField(position, property);
            position.y += position.height + EditorGUIUtility.standardVerticalSpacing;
        }

        public static void Field(ref Rect position, SerializedProperty property, string label)
        {
            position.height = EditorGUIUtility.singleLineHeight;
            EditorGUI.PropertyField(position, property, new GUIContent(label), true);
            position.y += EditorGUI.GetPropertyHeight(property) + EditorGUIUtility.standardVerticalSpacing;
        }

        public static void AddPropertyHeight(ref float height, SerializedProperty property, bool insertSpace = true)
        {
            height += EditorGUI.GetPropertyHeight(property) + EditorGUIUtility.standardVerticalSpacing;
        }
    }

}