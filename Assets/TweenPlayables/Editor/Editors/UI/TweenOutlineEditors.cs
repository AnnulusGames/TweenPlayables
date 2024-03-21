using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenOutlineTrack))]
    public sealed class TweenOutlineTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.outlineIcon;
        public override string DefaultTrackName => "Tween Outline Track";
    }

    [CustomTimelineEditor(typeof(TweenOutlineClip))]
    public sealed class TweenOutlineClipEditor : TweenAnimationClipEditor
    {
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.outlineIcon;
        public override string DefaultClipName => "Tween Outline";
    }

    [CustomPropertyDrawer(typeof(TweenOutlineBehaviour))]
    public sealed class TweenOutlineBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "color", "distance"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}