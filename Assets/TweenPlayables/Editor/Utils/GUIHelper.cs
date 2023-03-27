using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace AnnulusGames.TweenPlayables.Editor
{
    public static class GUIHelper
    {
        public static void Field(ref Rect position, SerializedProperty property)
        {
            position.height = EditorGUI.GetPropertyHeight(property);
            EditorGUI.PropertyField(position, property);
            position.y += position.height + EditorGUIUtility.standardVerticalSpacing;
        }
    }

}