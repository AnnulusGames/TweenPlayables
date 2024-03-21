using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenOutlineTrack))]
    public sealed class TweenOutlineTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styles.UGUIColor;
        public override Texture2D TrackIcon => Styles.OutlineIcon;
        public override string DefaultTrackName => "Tween Outline Track";
    }

    [CustomTimelineEditor(typeof(TweenOutlineClip))]
    public sealed class TweenOutlineClipEditor : TweenAnimationClipEditor
    {
        public override Color ClipColor => Styles.UGUIColor;
        public override Texture2D ClipIcon => Styles.OutlineIcon;
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