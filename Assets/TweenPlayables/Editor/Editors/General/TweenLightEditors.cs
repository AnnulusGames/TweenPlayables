using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenLightTrack))]
    public sealed class TweenLightTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styles.LightColor;
        public override Texture2D TrackIcon => Styles.LightIcon;
        public override string DefaultTrackName => "Tween Light Track";
    }

    [CustomTimelineEditor(typeof(TweenLightClip))]
    public sealed class TweenLightClipEditor : TweenAnimationClipEditor
    {
        public override Color ClipColor => Styles.LightColor;
        public override Texture2D ClipIcon => Styles.LightIcon;
        public override string DefaultClipName => "Tween Light";
    }

    [CustomPropertyDrawer(typeof(TweenLightBehaviour))]
    public sealed class TweenLightBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "color", "intensity", "shadowStrength"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}