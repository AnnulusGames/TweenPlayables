using System;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEditor;

namespace TweenPlayables.Editor
{
    [CustomPropertyDrawer(typeof(TweenParameter<>), true)]
    public class TweenParamterDrawer : PropertyDrawer
    {
        protected static readonly float headerHeight = EditorGUIUtility.singleLineHeight * 1.2f;

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            position.xMin += 15f * indent;

            var activeProperty = property.FindPropertyRelative("active");
            var height = GetPropertyHeight(property, label);

            var boxRect = position;
            boxRect.xMin -= 3f;
            boxRect.height = height;
            EditorGUI.LabelField(boxRect, GUIContent.none, EditorStyles.helpBox);

            var foldoutRect = position;
            foldoutRect.xMin += 15f;
            foldoutRect.height = headerHeight;

            var active = activeProperty.boolValue;
            property.isExpanded = Styles.ToggleGroup(foldoutRect, property.isExpanded, ref active, property.displayName);
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
            var height = headerHeight;
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
    public sealed class StringTweenParameterDrawer : TweenParamterDrawer
    {
        public override void DrawProperties(Rect position, SerializedProperty property)
        {
            DrawTextArea(ref position, property.FindPropertyRelative("startValue"), new GUIContent("Start"));
            DrawTextArea(ref position, property.FindPropertyRelative("endValue"), new GUIContent("End"));
            GUIHelper.Field(ref position, property.FindPropertyRelative("ease"), "Ease");

            SerializedProperty scrambleModeProeprty = property.FindPropertyRelative("scrambleMode");
            GUIHelper.Field(ref position, scrambleModeProeprty, "Scramble Mode");

            if (scrambleModeProeprty.enumValueIndex == (int)ScrambleMode.Custom)
            {
                GUIHelper.Field(ref position, property.FindPropertyRelative("customScrambleChars"), "Custom Scramble Chars");
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var height = headerHeight;
            if (property.isExpanded)
            {
                height += (EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing) * 2;
                height += GetTextAreaHeight(property.FindPropertyRelative("startValue").stringValue);
                height += GetTextAreaHeight(property.FindPropertyRelative("endValue").stringValue);

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

        static void DrawTextArea(ref Rect position, SerializedProperty property, GUIContent label)
        {
            var labelRect = new Rect()
            {
                x = position.x,
                y = position.y,
                width = position.width,
                height = EditorGUIUtility.singleLineHeight
            };

            EditorGUI.LabelField(labelRect, label.text);

            using (var changeCheck = new EditorGUI.ChangeCheckScope())
            {
                var textAreaRect = new Rect()
                {
                    x = labelRect.x,
                    y = labelRect.y + EditorGUIUtility.singleLineHeight,
                    width = labelRect.width,
                    height = GetTextAreaHeight(property.stringValue)
                };

                var textAreaValue = EditorGUI.TextArea(textAreaRect, property.stringValue);

                if (changeCheck.changed)
                {
                    property.stringValue = textAreaValue;
                }

                position.y += textAreaRect.height + EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;
            }
        }

        static int GetNumberOfLines(string text)
        {
            var content = Regex.Replace(text, @"\r\n|\n\r|\r|\n", Environment.NewLine);
            var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            return lines.Length;
        }

        static float GetTextAreaHeight(string text)
        {
            var height = (EditorGUIUtility.singleLineHeight - 3.0f) * GetNumberOfLines(text) + 3.0f;
            return Math.Max(height, EditorGUIUtility.singleLineHeight * 2.5f);
        }
    }
}