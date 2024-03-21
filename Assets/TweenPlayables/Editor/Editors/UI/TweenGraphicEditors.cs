using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenGraphicTrack))]
    public sealed class TweenGraphicTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styles.UGUIColor;
        public override Texture2D TrackIcon => Styles.CsScriptIcon;
        public override string DefaultTrackName => "Tween Graphic Track";
    }

    [CustomTimelineEditor(typeof(TweenGraphicClip))]
    public sealed class TweenGraphicClipEditor : TweenAnimationClipEditor
    {
        public override Color ClipColor => Styles.UGUIColor;
        public override Texture2D ClipIcon => Styles.CsScriptIcon;
        public override string DefaultClipName => "Tween Graphic";
    }

    [CustomPropertyDrawer(typeof(TweenGraphicBehaviour))]
    public sealed class TweenGraphicBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "color"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}