using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenTransformTrack))]
    public sealed class TweenTransformTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.transformColor;
        public override Texture2D TrackIcon => Styling.transformIcon;
        public override string DefaultTrackName => "Tween Transform Track";
    }

    [CustomTimelineEditor(typeof(TweenTransformClip))]
    public sealed class TweenTransformClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween Transform";
        public override Color ClipColor => Styling.transformColor;
        public override Texture2D ClipIcon => Styling.transformIcon;
    }

    [CustomPropertyDrawer(typeof(TweenTransformBehaviour))]
    public sealed class TweenTransformBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("position"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("rotation"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("scale"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 11f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("position"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("rotation"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("scale"));

            return height;
        }
    }
}