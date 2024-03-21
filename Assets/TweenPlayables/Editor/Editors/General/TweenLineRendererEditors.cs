using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenLineRendererTrack))]
    public sealed class TweenLineRendererTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styles.RendererColor;
        public override Texture2D TrackIcon => Styles.LineRendererIcon;
        public override string DefaultTrackName => "Tween LineRenderer Track";
    }

    [CustomTimelineEditor(typeof(TweenLineRendererClip))]
    public sealed class TweenLineRendererClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween LineRenderer";
        public override Color ClipColor => Styles.RendererColor;
        public override Texture2D ClipIcon => Styles.LineRendererIcon;
    }

    [CustomPropertyDrawer(typeof(TweenLineRendererBehaviour))]
    public sealed class TweenLineRendererBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "startColor", "endColor", "startWidth", "endWidth"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}