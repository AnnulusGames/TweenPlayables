using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenLightTrack))]
    public sealed class TweenLightTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.lightColor;
        public override Texture2D TrackIcon => Styling.lightIcon;
        public override string DefaultTrackName => "Tween Light Track";
    }

    [CustomTimelineEditor(typeof(TweenLightClip))]
    public sealed class TweenLightClipEditor : TweenAnimationClipEditor
    {
        public override Color ClipColor => Styling.lightColor;
        public override Texture2D ClipIcon => Styling.lightIcon;
        public override string DefaultClipName => "Tween Light";
    }

    [CustomPropertyDrawer(typeof(TweenLightBehaviour))]
    public sealed class TweenLightBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("color"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("intensity"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("shadowStrength"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 9f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("color"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("intensity"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("shadowStrength"));

            return height;
        }
    }
}