using UnityEngine;
using UnityEditor;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomPropertyDrawer(typeof(TweenParameter<>), true)]
    public class TweenParamterDrawer : PropertyDrawer
    {
        private float headerHeight = EditorGUIUtility.singleLineHeight * 1.2f;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            int indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            position.xMin += 15f * indent;

            SerializedProperty activeProperty = property.FindPropertyRelative("active");
            float height = GetPropertyHeight(property, label);

            Rect boxRect = position;
            boxRect.xMin -= 3f;
            boxRect.height = height;
            EditorGUI.LabelField(boxRect, GUIContent.none, EditorStyles.helpBox);

            Rect foldoutRect = position;
            foldoutRect.xMin += 15f;
            foldoutRect.height = headerHeight;

            bool active = activeProperty.boolValue;
            property.isExpanded = Styling.ToggleGroup(foldoutRect, property.isExpanded, ref active, property.displayName);
            activeProperty.boolValue = active;
            if (property.isExpanded)
            {
                position.y += headerHeight + EditorGUIUtility.standardVerticalSpacing;
                position.xMin += 15f;
                using (new EditorGUI.DisabledGroupScope(!activeProperty.boolValue))
                {
                    Field(ref position, property.FindPropertyRelative("startValue"), "Start");
                    Field(ref position, property.FindPropertyRelative("endValue"), "End");
                    Field(ref position, property.FindPropertyRelative("ease"), "Ease");
                    Field(ref position, property.FindPropertyRelative("relative"), "Relative");
                }
            }

            EditorGUI.indentLevel = indent;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = headerHeight;
            if (property.isExpanded)
            {
                AddHeight(ref height, property.FindPropertyRelative("startValue"));
                AddHeight(ref height, property.FindPropertyRelative("endValue"));
                AddHeight(ref height, property.FindPropertyRelative("ease"));
                AddHeight(ref height, property.FindPropertyRelative("relative"));
                height += EditorGUIUtility.standardVerticalSpacing;
            }
            height += EditorGUIUtility.standardVerticalSpacing;
            return height;
        }

        private void Field(ref Rect position, SerializedProperty property, string label)
        {
            position.height = EditorGUIUtility.singleLineHeight;
            EditorGUI.PropertyField(position, property, new GUIContent(label), true);
            position.y += EditorGUI.GetPropertyHeight(property) + EditorGUIUtility.standardVerticalSpacing;
        }

        private void AddHeight(ref float height, SerializedProperty property, bool insertSpace = true)
        {
            height += EditorGUI.GetPropertyHeight(property) + EditorGUIUtility.standardVerticalSpacing;
        }
    }
}