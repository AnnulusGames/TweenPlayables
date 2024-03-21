using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenTransformTrack))]
    public sealed class TweenTransformTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.transformColor;
        public override Texture2D TrackIcon => Styling.transformIcon;
        public override string DefaultTrackName => "Tween Transform Track";
    }

    [CustomTimelineEditor(typeof(TweenTransformClip))]
    public sealed class TweenTransformClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween Transform";
        public override Color ClipColor => Styling.transformColor;
        public override Texture2D ClipIcon => Styling.transformIcon;
    }

    [CustomPropertyDrawer(typeof(TweenTransformBehaviour))]
    public sealed class TweenTransformBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "position", "rotation", "scale"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}