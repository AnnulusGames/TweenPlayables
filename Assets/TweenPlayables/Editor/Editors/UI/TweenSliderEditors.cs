using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenSliderTrack))]
    public sealed class TweenSliderTrackEditor : TweenAnimationTrackEditor
    {
        public override string DefaultTrackName => "Tween Slider Track";
        public override Color TrackColor => Styles.UGUIColor;
        public override Texture2D TrackIcon => Styles.SliderIcon;
    }

    [CustomTimelineEditor(typeof(TweenSliderClip))]
    public sealed class TweenSliderClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween Slider";
        public override Color ClipColor => Styles.UGUIColor;
        public override Texture2D ClipIcon => Styles.SliderIcon;
    }

    [CustomPropertyDrawer(typeof(TweenSliderBehaviour))]
    public sealed class TweenSliderBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "value",
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}