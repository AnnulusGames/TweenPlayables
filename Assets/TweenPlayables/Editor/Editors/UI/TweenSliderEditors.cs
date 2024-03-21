using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenSliderTrack))]
    public sealed class TweenSliderTrackEditor : TweenAnimationTrackEditor
    {
        public override string DefaultTrackName => "Tween Slider Track";
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.sliderIcon;
    }

    [CustomTimelineEditor(typeof(TweenSliderClip))]
    public sealed class TweenSliderClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween Slider";
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.sliderIcon;
    }

    [CustomPropertyDrawer(typeof(TweenSliderBehaviour))]
    public sealed class TweenSliderBehaviourDrawer : PropertyDrawer
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