using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenShadowTrack))]
    public sealed class TweenShadowTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styles.UGUIColor;
        public override Texture2D TrackIcon => Styles.ShadowIcon;
        public override string DefaultTrackName => "Tween Shadow Track";
    }

    [CustomTimelineEditor(typeof(TweenShadowClip))]
    public sealed class TweenShadowClipEditor : TweenAnimationClipEditor
    {
        public override Color ClipColor => Styles.UGUIColor;
        public override Texture2D ClipIcon => Styles.ShadowIcon;
        public override string DefaultClipName => "Tween Shadow";
    }

    [CustomPropertyDrawer(typeof(TweenShadowBehaviour))]
    public sealed class TweenShadowBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "color", "distance"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}