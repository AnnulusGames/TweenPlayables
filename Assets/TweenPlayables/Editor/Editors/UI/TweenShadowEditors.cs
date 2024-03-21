using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenShadowTrack))]
    public sealed class TweenShadowTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.shadowIcon;
        public override string DefaultTrackName => "Tween Shadow Track";
    }

    [CustomTimelineEditor(typeof(TweenShadowClip))]
    public sealed class TweenShadowClipEditor : TweenAnimationClipEditor
    {
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.shadowIcon;
        public override string DefaultClipName => "Tween Shadow";
    }

    [CustomPropertyDrawer(typeof(TweenShadowBehaviour))]
    public sealed class TweenShadowBehaviourDrawer : PropertyDrawer
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