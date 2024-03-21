using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenImageTrack))]
    public sealed class TweenImageTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.imageIcon;
        public override string DefaultTrackName => "Tween Image Track";
    }

    [CustomTimelineEditor(typeof(TweenImageClip))]
    public sealed class TweenImageClipEditor : TweenAnimationClipEditor
    {
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.imageIcon;
        public override string DefaultClipName => "Tween Image";
    }

    [CustomPropertyDrawer(typeof(TweenImageBehaviour))]
    public sealed class TweenImageBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("color"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("fillAmount"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 7f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("color"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("fillAmount"));

            return height;
        }
    }
}