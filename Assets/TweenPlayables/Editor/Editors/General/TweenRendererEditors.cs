using System.Collections.Generic;
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
    public sealed class TweenRendererBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "color", "textureOffset", "textureScale"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}