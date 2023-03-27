using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenCameraTrack))]
    public class TweenCameraTrackEditor : TweenAnimationTrackEditor
    {
        public override string defaultTrackName => "Tween Camera Track";
        public override Color trackColor => Styling.cameraColor;
        public override Texture2D trackIcon => Styling.cameraIcon;
    }

    [CustomTimelineEditor(typeof(TweenCameraClip))]
    public class TweenCameraClipEditor : TweenAnimationClipEditor
    {
        public override string defaultClipName => "Tween Camera";
        public override Color clipColor => Styling.cameraColor;
        public override Texture2D clipIcon => Styling.cameraIcon;
    }

    [CustomPropertyDrawer(typeof(TweenCameraBehaviour))]
    public class TweenCameraBehaviourDrawer : PropertyDrawer
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