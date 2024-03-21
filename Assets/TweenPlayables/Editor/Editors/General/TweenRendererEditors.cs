using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenRendererTrack))]
    public sealed class TweenRendererTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.rendererColor;
        public override Texture2D TrackIcon => Styling.meshRendererIcon;
        public override string DefaultTrackName => "Tween Renderer Track";
    }

    [CustomTimelineEditor(typeof(TweenRendererClip))]
    public sealed class TweenRendererClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween Renderer";
        public override Color ClipColor => Styling.rendererColor;
        public override Texture2D ClipIcon => Styling.meshRendererIcon;
    }

    [CustomPropertyDrawer(typeof(TweenRendererBehaviour))]
    public sealed class TweenRendererBehaviourDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            position.y += 7f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("color"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("textureOffset"));
            position.y += 2f;
            GUIHelper.Field(ref position, property.FindPropertyRelative("textureScale"));
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            float height = 11f;
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("color"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("textureOffset"));
            height += EditorGUI.GetPropertyHeight(property.FindPropertyRelative("textureScale"));

            return height;
        }
    }
}