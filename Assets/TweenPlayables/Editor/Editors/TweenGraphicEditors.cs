using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenGraphicTrack))]
    public class TweenGraphicTrackEditor : TweenAnimationTrackEditor
    {
        public override Color trackColor => Styling.uguiColor;
        public override Texture2D trackIcon => Styling.csScriptIcon;
        public override string defaultTrackName => "Tween Graphic Track";
    }

    [CustomTimelineEditor(typeof(TweenGraphicClip))]
    public class TweenGraphicClipEditor : TweenAnimationClipEditor
    {
        public override Color clipColor => Styling.uguiColor;
        public override Texture2D clipIcon => Styling.csScriptIcon;
        public override string defaultClipName => "Tween Graphic";
    }

    [CustomPropertyDrawer(typeof(TweenGraphicBehaviour))]
    public class TweenGraphicBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("color"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 7f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("color"));

            return height;
        }
    }
}