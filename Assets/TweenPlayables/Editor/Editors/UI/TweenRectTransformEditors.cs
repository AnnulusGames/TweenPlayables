using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenRectTransformTrack))]
    public sealed class TweenRectTransformTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styles.UGUIColor;
        public override Texture2D TrackIcon => Styles.RectTransformIcon;
        public override string DefaultTrackName => "Tween RectTransform Track";
    }

    [CustomTimelineEditor(typeof(TweenRectTransformClip))]
    public sealed class TweenRectTransformClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween RectTransform";
        public override Color ClipColor => Styles.UGUIColor;
        public override Texture2D ClipIcon => Styles.RectTransformIcon;
    }

    [CustomPropertyDrawer(typeof(TweenRectTransformBehaviour))]
    public sealed class TweenRectTransformBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "anchoredPosition", "sizeDelta", "rotation", "scale"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}