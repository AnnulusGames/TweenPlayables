using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenTextTrack))]
    public sealed class TweenTextTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styles.UGUIColor;
        public override Texture2D TrackIcon => Styles.TextIcon;
        public override string DefaultTrackName => "Tween Text Track";
    }

    [CustomTimelineEditor(typeof(TweenTextClip))]
    public sealed class TweenTextClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween Text";
        public override Color ClipColor => Styles.UGUIColor;
        public override Texture2D ClipIcon => Styles.TextIcon;
    }

    [CustomPropertyDrawer(typeof(TweenTextBehaviour))]
    public sealed class TweenTextBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "color", "fontSize", "lineSpacing", "text"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}