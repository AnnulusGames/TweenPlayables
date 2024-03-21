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
        public override Color TrackColor => Styles.UGUIColor;
        public override Texture2D TrackIcon => Styles.CanvasGroupIcon;
    }

    [CustomTimelineEditor(typeof(TweenCanvasGroupClip))]
    public sealed class TweenCanvasGroupClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween CanvasGroup";
        public override Color ClipColor => Styles.UGUIColor;
        public override Texture2D ClipIcon => Styles.CanvasGroupIcon;
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