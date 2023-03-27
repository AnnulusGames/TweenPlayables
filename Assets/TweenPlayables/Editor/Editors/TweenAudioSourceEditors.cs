using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenAudioSourceTrack))]
    public class TweenAudioSourceTrackEditor : TweenAnimationTrackEditor
    {
        public override Color trackColor => Styling.audioColor;
        public override Texture2D trackIcon => Styling.audioSourceIcon;
        public override string defaultTrackName => "Tween AudioSource Track";
    }

    [CustomTimelineEditor(typeof(TweenAudioSourceClip))]
    public class TweenAudioSourceClipEditor : TweenAnimationClipEditor
    {
        public override string defaultClipName => "Tween AudioSource";
        public override Color clipColor => Styling.audioColor;
        public override Texture2D clipIcon => Styling.audioSourceIcon;
    }

    [CustomPropertyDrawer(typeof(TweenAudioSourceBehaviour))]
    public class TweenAudioSourceBehaviourDrawer : PropertyDrawer
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