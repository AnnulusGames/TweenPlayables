using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenLineRendererTrack))]
    public sealed class TweenLineRendererTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.rendererColor;
        public override Texture2D TrackIcon => Styling.lineRendererIcon;
        public override string DefaultTrackName => "Tween LineRenderer Track";
    }

    [CustomTimelineEditor(typeof(TweenLineRendererClip))]
    public sealed class TweenLineRendererClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween LineRenderer";
        public override Color ClipColor => Styling.rendererColor;
        public override Texture2D ClipIcon => Styling.lineRendererIcon;
    }

    [CustomPropertyDrawer(typeof(TweenLineRendererBehaviour))]
    public sealed class TweenLineRendererBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("startColor"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("endColor"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("startWidth"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("endWidth"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 13f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("startColor"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("endColor"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("startWidth"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("endWidth"));

            return height;
        }
    }
}