using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenCanvasGroupTrack))]
    public class TweenCanvasGroupTrackEditor : TweenAnimationTrackEditor
    {
        public override string defaultTrackName => "Tween CanvasGroup Track";
        public override Color trackColor => Styling.uguiColor;
        public override Texture2D trackIcon => Styling.canvasGroupIcon;
    }

    [CustomTimelineEditor(typeof(TweenCanvasGroupClip))]
    public class TweenCanvasGroupClipEditor : TweenAnimationClipEditor
    {
        public override string defaultClipName => "Tween CanvasGroup";
        public override Color clipColor => Styling.uguiColor;
        public override Texture2D clipIcon => Styling.canvasGroupIcon;
    }

    [CustomPropertyDrawer(typeof(TweenCanvasGroupBehaviour))]
    public class TweenCanvasGroupBehaviourDrawer : PropertyDrawer
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