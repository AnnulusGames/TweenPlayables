using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenTextTrack))]
    public sealed class TweenTextTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.textIcon;
        public override string DefaultTrackName => "Tween Text Track";
    }

    [CustomTimelineEditor(typeof(TweenTextClip))]
    public sealed class TweenTextClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween Text";
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.textIcon;
    }

    [CustomPropertyDrawer(typeof(TweenTextBehaviour))]
    public sealed class TweenTextBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("color"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("fontSize"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("lineSpacing"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("text"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 15f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("color"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("fontSize"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("lineSpacing"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("text"));

            return height;
        }
    }
}