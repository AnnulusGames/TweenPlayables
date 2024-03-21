using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace TweenPlayables.Editor
{
    public abstract class TweenAnimationBehaviourDrawer : PropertyDrawer
    {
        protected abstract IEnumerable<string> GetPropertyNames();

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            foreach (var propertyName in GetPropertyNames())
            {
                GUIHelper.Field(ref position, property.FindPropertyRelative(propertyName));
                position.y += 2f;
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var height = 9f;
            foreach (var propertyName in GetPropertyNames())
            {
                height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative(propertyName));
            }

            return height;
        }
    }
}