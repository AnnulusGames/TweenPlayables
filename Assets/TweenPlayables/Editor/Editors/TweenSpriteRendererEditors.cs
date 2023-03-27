using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenSpriteRendererTrack))]
    public class TweenSpriteRendererTrackEditor : TweenAnimationTrackEditor
    {
        public override Color trackColor => Styling.rendererColor;
        public override Texture2D trackIcon => Styling.spriteRendererIcon;
        public override string defaultTrackName => "Tween SpriteRenderer Track";
    }

    [CustomTimelineEditor(typeof(TweenSpriteRendererClip))]
    public class TweenSpriteRendererClipEditor : TweenAnimationClipEditor
    {
        public override string defaultClipName => "Tween SpriteRenderer";
        public override Color clipColor => Styling.rendererColor;
        public override Texture2D clipIcon => Styling.spriteRendererIcon;
    }

    [CustomPropertyDrawer(typeof(TweenSpriteRendererBehaviour))]
    public class TweenSpriteRendererBehaviourDrawer : PropertyDrawer
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