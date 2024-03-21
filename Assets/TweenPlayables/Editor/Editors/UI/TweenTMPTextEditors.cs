using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenTMPTextTrack))]
    public sealed class TweenTMPTextTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.textMeshProUGUIIcon;
        public override string DefaultTrackName => "Tween TMP_Text Track";
    }

    [CustomTimelineEditor(typeof(TweenTMPTextClip))]
    public sealed class TweenTMPTextClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween TMP_Text";
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.textMeshProUGUIIcon;
    }

    [CustomPropertyDrawer(typeof(TweenTMPTextBehaviour))]
    public sealed class TweenTMPTextBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("color"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("fontSize"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("characterSpacing"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("lineSpacing"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("wordSpacing"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("paragraphSpacing"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("colorGradient"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("text"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 27f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("color"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("fontSize"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("characterSpacing"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("lineSpacing"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("wordSpacing"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("paragraphSpacing"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("colorGradient"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("text"));

            return height;
        }
    }
}