using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenAudioSourceTrack))]
    public sealed class TweenAudioSourceTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.audioColor;
        public override Texture2D TrackIcon => Styling.audioSourceIcon;
        public override string DefaultTrackName => "Tween AudioSource Track";
    }

    [CustomTimelineEditor(typeof(TweenAudioSourceClip))]
    public sealed class TweenAudioSourceClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween AudioSource";
        public override Color ClipColor => Styling.audioColor;
        public override Texture2D ClipIcon => Styling.audioSourceIcon;
    }

    [CustomPropertyDrawer(typeof(TweenAudioSourceBehaviour))]
    public sealed class TweenAudioSourceBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("volume"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("pitch"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 9f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("volume"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("pitch"));

            return height;
        }
    }
}