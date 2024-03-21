using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenSpriteRendererTrack))]
    public sealed class TweenSpriteRendererTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styles.RendererColor;
        public override Texture2D TrackIcon => Styles.SpriteRendererIcon;
        public override string DefaultTrackName => "Tween SpriteRenderer Track";
    }

    [CustomTimelineEditor(typeof(TweenSpriteRendererClip))]
    public sealed class TweenSpriteRendererClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween SpriteRenderer";
        public override Color ClipColor => Styles.RendererColor;
        public override Texture2D ClipIcon => Styles.SpriteRendererIcon;
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