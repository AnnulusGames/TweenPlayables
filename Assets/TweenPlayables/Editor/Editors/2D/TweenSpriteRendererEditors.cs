using System.Collections.Generic;
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
    public sealed class TweenSpriteRendererBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "color",
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}