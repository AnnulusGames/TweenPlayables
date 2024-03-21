using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;
using System.Collections.Generic;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenCanvasGroupTrack))]
    public sealed class TweenCanvasGroupTrackEditor : TweenAnimationTrackEditor
    {
        public override string DefaultTrackName => "Tween CanvasGroup Track";
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.canvasGroupIcon;
    }

    [CustomTimelineEditor(typeof(TweenCanvasGroupClip))]
    public sealed class TweenCanvasGroupClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween CanvasGroup";
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.canvasGroupIcon;
    }

    [CustomPropertyDrawer(typeof(TweenCanvasGroupBehaviour))]
    public sealed class TweenCanvasGroupBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "alpha"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}