using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenImageTrack))]
    public sealed class TweenImageTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.imageIcon;
        public override string DefaultTrackName => "Tween Image Track";
    }

    [CustomTimelineEditor(typeof(TweenImageClip))]
    public sealed class TweenImageClipEditor : TweenAnimationClipEditor
    {
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.imageIcon;
        public override string DefaultClipName => "Tween Image";
    }

    [CustomPropertyDrawer(typeof(TweenImageBehaviour))]
    public sealed class TweenImageBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "color", "fillAmount"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}