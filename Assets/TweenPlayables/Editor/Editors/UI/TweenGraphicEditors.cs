using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenGraphicTrack))]
    public sealed class TweenGraphicTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.csScriptIcon;
        public override string DefaultTrackName => "Tween Graphic Track";
    }

    [CustomTimelineEditor(typeof(TweenGraphicClip))]
    public sealed class TweenGraphicClipEditor : TweenAnimationClipEditor
    {
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.csScriptIcon;
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