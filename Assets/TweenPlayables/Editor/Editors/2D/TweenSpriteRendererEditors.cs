using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenSpriteRendererTrack))]
    public sealed class TweenSpriteRendererTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.rendererColor;
        public override Texture2D TrackIcon => Styling.spriteRendererIcon;
        public override string DefaultTrackName => "Tween SpriteRenderer Track";
    }

    [CustomTimelineEditor(typeof(TweenSpriteRendererClip))]
    public sealed class TweenSpriteRendererClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween SpriteRenderer";
        public override Color ClipColor => Styling.rendererColor;
        public override Texture2D ClipIcon => Styling.spriteRendererIcon;
    }

    [CustomPropertyDrawer(typeof(TweenSpriteRendererBehaviour))]
    public sealed class TweenSpriteRendererBehaviourDrawer : PropertyDrawer
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