using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenRectTransformTrack))]
    public sealed class TweenRectTransformTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.rectTransformIcon;
        public override string DefaultTrackName => "Tween RectTransform Track";
    }

    [CustomTimelineEditor(typeof(TweenRectTransformClip))]
    public sealed class TweenRectTransformClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween RectTransform";
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.rectTransformIcon;
    }

    [CustomPropertyDrawer(typeof(TweenRectTransformBehaviour))]
    public sealed class TweenRectTransformBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("anchoredPosition"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("sizeDelta"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("rotation"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("scale"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 13f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("anchoredPosition"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("sizeDelta"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("rotation"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("scale"));

            return height;
        }
    }
}