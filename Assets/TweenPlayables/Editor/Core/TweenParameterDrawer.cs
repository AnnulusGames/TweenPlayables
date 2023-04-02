using UnityEngine;
using UnityEditor;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomPropertyDrawer(typeof(TweenParameter<>), true)]
    public class TweenParamterDrawer : PropertyDrawer
    {
        protected float headerHeight = EditorGUIUtility.singleLineHeight * 1.2f;

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
                position.xMax -= 5f;
                using (new EditorGUI.DisabledGroupScope(!activeProperty.boolValue))
                {
                    DrawProperties(position, property);
                }
            }

            EditorGUI.indentLevel = indent;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = headerHeight;
            if (property.isExpanded)
            {
                GUIHelper.AddPropertyHeight(ref height, property.FindPropertyRelative("startValue"));
                GUIHelper.AddPropertyHeight(ref height, property.FindPropertyRelative("endValue"));
                GUIHelper.AddPropertyHeight(ref height, property.FindPropertyRelative("ease"));
                GUIHelper.AddPropertyHeight(ref height, property.FindPropertyRelative("relative"));
                height += EditorGUIUtility.standardVerticalSpacing;
            }
            height += EditorGUIUtility.standardVerticalSpacing;
            return height;
        }

        public virtual void DrawProperties(Rect position, SerializedProperty property)
        {
            GUIHelper.Field(ref position, property.FindPropertyRelative("startValue"), "Start");
            GUIHelper.Field(ref position, property.FindPropertyRelative("endValue"), "End");
            GUIHelper.Field(ref position, property.FindPropertyRelative("ease"), "Ease");
            GUIHelper.Field(ref position, property.FindPropertyRelative("relative"), "Relative");
        }
    }

    [CustomPropertyDrawer(typeof(StringTweenParameter))]
    public class StringTweenParameterDrawer : TweenParamterDrawer
    {
        public override void DrawProperties(Rect position, SerializedProperty property)
        {
            GUIHelper.Field(ref position, property.FindPropertyRelative("startValue"), "Start");
            GUIHelper.Field(ref position, property.FindPropertyRelative("endValue"), "End");
            GUIHelper.Field(ref position, property.FindPropertyRelative("ease"), "Ease");

            SerializedProperty scrambleModeProeprty = property.FindPropertyRelative("scrambleMode");
            GUIHelper.Field(ref position, scrambleModeProeprty, "Scramble Mode");

            if (scrambleModeProeprty.enumValueIndex == (int)ScrambleMode.Custom)
            {
                GUIHelper.Field(ref position,property.FindPropertyRelative("customScrambleChars"), "Custom Scramble Chars");
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = headerHeight;
            if (property.isExpanded)
            {
                GUIHelper.AddPropertyHeight(ref height, property.FindPropertyRelative("startValue"));
                GUIHelper.AddPropertyHeight(ref height, property.FindPropertyRelative("endValue"));
                GUIHelper.AddPropertyHeight(ref height, property.FindPropertyRelative("ease"));

                SerializedProperty scrambleModeProeprty = property.FindPropertyRelative("scrambleMode");
                GUIHelper.AddPropertyHeight(ref height, scrambleModeProeprty);

                if (scrambleModeProeprty.enumValueIndex == (int)ScrambleMode.Custom)
                {
                    GUIHelper.AddPropertyHeight(ref height, property.FindPropertyRelative("customScrambleChars"));
                }

                height += EditorGUIUtility.standardVerticalSpacing;
            }
            height += EditorGUIUtility.standardVerticalSpacing;

            return height;
        }
    }
}