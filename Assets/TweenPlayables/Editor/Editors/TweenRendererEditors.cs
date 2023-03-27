using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenRendererTrack))]
    public class TweenRendererTrackEditor : TweenAnimationTrackEditor
    {
        public override Color trackColor => Styling.rendererColor;
        public override Texture2D trackIcon => Styling.meshRendererIcon;
        public override string defaultTrackName => "Tween Renderer Track";
    }

    [CustomTimelineEditor(typeof(TweenRendererClip))]
    public class TweenRendererClipEditor : TweenAnimationClipEditor
    {
        public override string defaultClipName => "Tween Renderer";
        public override Color clipColor => Styling.rendererColor;
        public override Texture2D clipIcon => Styling.meshRendererIcon;
    }

    [CustomPropertyDrawer(typeof(TweenRendererBehaviour))]
    public class TweenRendererBehaviourDrawer : PropertyDrawer
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