using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenCameraTrack))]
    public sealed class TweenCameraTrackEditor : TweenAnimationTrackEditor
    {
        public override string DefaultTrackName => "Tween Camera Track";
        public override Color TrackColor => Styling.cameraColor;
        public override Texture2D TrackIcon => Styling.cameraIcon;
    }

    [CustomTimelineEditor(typeof(TweenCameraClip))]
    public sealed class TweenCameraClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween Camera";
        public override Color ClipColor => Styling.cameraColor;
        public override Texture2D ClipIcon => Styling.cameraIcon;
    }

    [CustomPropertyDrawer(typeof(TweenCameraBehaviour))]
    public sealed class TweenCameraBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("fieldOfView"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("orthographicSize"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("backgroundColor"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 9f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("fieldOfView"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("orthographicSize"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("backgroundColor"));

            return height;
        }
    }
}