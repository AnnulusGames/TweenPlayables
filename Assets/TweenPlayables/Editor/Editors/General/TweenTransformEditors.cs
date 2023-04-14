using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;
using UnityEditor.Playables;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenTransformTrack))]
    public class TweenTransformTrackEditor : TweenAnimationTrackEditor
    {
        public override Color trackColor => Styling.transformColor;
        public override Texture2D trackIcon => Styling.transformIcon;
        public override string defaultTrackName => "Tween Transform Track";
    }

    [CustomTimelineEditor(typeof(TweenTransformClip))]
    public class TweenTransformClipEditor : TweenAnimationClipEditor
    {
        public override string defaultClipName => "Tween Transform";
        public override Color clipColor => Styling.transformColor;
        public override Texture2D clipIcon => Styling.transformIcon;
    }

    [CustomPropertyDrawer(typeof(TweenTransformBehaviour))]
    public class TweenTransformBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("position"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("rotation"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("scale"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 11f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("position"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("rotation"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("scale"));

            return height;
        }
    }
}