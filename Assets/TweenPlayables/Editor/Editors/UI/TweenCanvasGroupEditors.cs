using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenCanvasGroupTrack))]
    public sealed class TweenCanvasGroupTrackEditor : TweenAnimationTrackEditor
    {
        public override string DefaultTrackName => "Tween CanvasGroup Track";
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.canvasGroupIcon;
    }

    [CustomTimelineEditor(typeof(TweenCanvasGroupClip))]
    public sealed class TweenCanvasGroupClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween CanvasGroup";
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.canvasGroupIcon;
    }

    [CustomPropertyDrawer(typeof(TweenCanvasGroupBehaviour))]
    public sealed class TweenCanvasGroupBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("alpha"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 7f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("alpha"));

            return height;
        }
    }
}