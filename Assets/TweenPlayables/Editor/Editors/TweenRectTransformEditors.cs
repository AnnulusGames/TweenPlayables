using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenRectTransformTrack))]
    public class TweenRectTransformTrackEditor : TweenAnimationTrackEditor
    {
        public override Color trackColor => Styling.uguiColor;
        public override Texture2D trackIcon => Styling.rectTransformIcon;
        public override string defaultTrackName => "Tween RectTransform Track";
    }

    [CustomTimelineEditor(typeof(TweenRectTransformClip))]
    public class TweenRectTransformClipEditor : TweenAnimationClipEditor
    {
        public override string defaultClipName => "Tween RectTransform";
        public override Color clipColor => Styling.uguiColor;
        public override Texture2D clipIcon => Styling.rectTransformIcon;
    }

    [CustomPropertyDrawer(typeof(TweenRectTransformBehaviour))]
    public class TweenRectTransformBehaviourDrawer : PropertyDrawer
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