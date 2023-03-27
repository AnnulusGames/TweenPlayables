using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenLightTrack))]
    public class TweenLightTrackEditor : TweenAnimationTrackEditor
    {
        public override Color trackColor => Styling.lightColor;
        public override Texture2D trackIcon => Styling.lightIcon;
        public override string defaultTrackName => "Tween Light Track";
    }

    [CustomTimelineEditor(typeof(TweenLightClip))]
    public class TweenLightClipEditor : TweenAnimationClipEditor
    {
        public override Color clipColor => Styling.lightColor;
        public override Texture2D clipIcon => Styling.lightIcon;
        public override string defaultClipName => "Tween Light";
    }

    [CustomPropertyDrawer(typeof(TweenLightBehaviour))]
    public class TweenLightBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("color"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("intensity"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("shadowStrength"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 9f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("color"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("intensity"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("shadowStrength"));

            return height;
        }
    }
}