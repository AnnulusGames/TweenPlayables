using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenImageTrack))]
    public class TweenImageTrackEditor : TweenAnimationTrackEditor
    {
        public override Color trackColor => Styling.uguiColor;
        public override Texture2D trackIcon => Styling.imageIcon;
        public override string defaultTrackName => "Tween Image Track";
    }

    [CustomTimelineEditor(typeof(TweenImageClip))]
    public class TweenImageClipEditor : TweenAnimationClipEditor
    {
        public override Color clipColor => Styling.uguiColor;
        public override Texture2D clipIcon => Styling.imageIcon;
        public override string defaultClipName => "Tween Image";
    }

    [CustomPropertyDrawer(typeof(TweenImageBehaviour))]
    public class TweenImageBehaviourDrawer : PropertyDrawer
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