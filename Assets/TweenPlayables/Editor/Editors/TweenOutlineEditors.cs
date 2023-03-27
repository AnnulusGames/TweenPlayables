using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenOutlineTrack))]
    public class TweenOutlineTrackEditor : TweenAnimationTrackEditor
    {
        public override Color trackColor => Styling.uguiColor;
        public override Texture2D trackIcon => Styling.outlineIcon;
        public override string defaultTrackName => "Tween Outline Track";
    }

    [CustomTimelineEditor(typeof(TweenOutlineClip))]
    public class TweenOutlineClipEditor : TweenAnimationClipEditor
    {
        public override Color clipColor => Styling.uguiColor;
        public override Texture2D clipIcon => Styling.outlineIcon;
        public override string defaultClipName => "Tween Outline";
    }

    [CustomPropertyDrawer(typeof(TweenOutlineBehaviour))]
    public class TweenOutlineBehaviourDrawer : PropertyDrawer
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