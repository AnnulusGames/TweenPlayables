using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenLineRendererTrack))]
    public class TweenLineRendererTrackEditor : TweenAnimationTrackEditor
    {
        public override Color trackColor => Styling.rendererColor;
        public override Texture2D trackIcon => Styling.lineRendererIcon;
        public override string defaultTrackName => "Tween LineRenderer Track";
    }

    [CustomTimelineEditor(typeof(TweenLineRendererClip))]
    public class TweenLineRendererClipEditor : TweenAnimationClipEditor
    {
        public override string defaultClipName => "Tween LineRenderer";
        public override Color clipColor => Styling.rendererColor;
        public override Texture2D clipIcon => Styling.lineRendererIcon;
    }

    [CustomPropertyDrawer(typeof(TweenLineRendererBehaviour))]
    public class TweenLineRendererBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("startColor"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("endColor"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("startWidth"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("endWidth"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 13f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("startColor"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("endColor"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("startWidth"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("endWidth"));

            return height;
        }
    }
}