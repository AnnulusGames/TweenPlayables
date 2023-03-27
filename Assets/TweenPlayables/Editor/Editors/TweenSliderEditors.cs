using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenSliderTrack))]
    public class TweenSliderTrackEditor : TweenAnimationTrackEditor
    {
        public override string defaultTrackName => "Tween Slider Track";
        public override Color trackColor => Styling.uguiColor;
        public override Texture2D trackIcon => Styling.sliderIcon;
    }

    [CustomTimelineEditor(typeof(TweenSliderClip))]
    public class TweenSliderClipEditor : TweenAnimationClipEditor
    {
        public override string defaultClipName => "Tween Slider";
        public override Color clipColor => Styling.uguiColor;
        public override Texture2D clipIcon => Styling.sliderIcon;
    }

    [CustomPropertyDrawer(typeof(TweenSliderBehaviour))]
    public class TweenSliderBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("value"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 7f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("value"));

            return height;
        }
    }
}