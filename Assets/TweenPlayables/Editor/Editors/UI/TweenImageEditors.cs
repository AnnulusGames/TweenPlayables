using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenImageTrack))]
    public sealed class TweenImageTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styles.UGUIColor;
        public override Texture2D TrackIcon => Styles.ImageIcon;
        public override string DefaultTrackName => "Tween Image Track";
    }

    [CustomTimelineEditor(typeof(TweenImageClip))]
    public sealed class TweenImageClipEditor : TweenAnimationClipEditor
    {
        public override Color ClipColor => Styles.UGUIColor;
        public override Texture2D ClipIcon => Styles.ImageIcon;
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