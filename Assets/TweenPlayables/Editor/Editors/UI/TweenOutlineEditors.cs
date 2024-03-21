using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenOutlineTrack))]
    public sealed class TweenOutlineTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.outlineIcon;
        public override string DefaultTrackName => "Tween Outline Track";
    }

    [CustomTimelineEditor(typeof(TweenOutlineClip))]
    public sealed class TweenOutlineClipEditor : TweenAnimationClipEditor
    {
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.outlineIcon;
        public override string DefaultClipName => "Tween Outline";
    }

    [CustomPropertyDrawer(typeof(TweenOutlineBehaviour))]
    public sealed class TweenOutlineBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("color"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("distance"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 7f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("color"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("distance"));

            return height;
        }
    }
}