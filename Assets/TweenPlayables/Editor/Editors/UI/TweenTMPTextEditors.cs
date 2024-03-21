using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenTMPTextTrack))]
    public sealed class TweenTMPTextTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styles.UGUIColor;
        public override Texture2D TrackIcon => Styles.TextMeshProUGUIIcon;
        public override string DefaultTrackName => "Tween TMP_Text Track";
    }

    [CustomTimelineEditor(typeof(TweenTMPTextClip))]
    public sealed class TweenTMPTextClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween TMP_Text";
        public override Color ClipColor => Styles.UGUIColor;
        public override Texture2D ClipIcon => Styles.TextMeshProUGUIIcon;
    }

    [CustomPropertyDrawer(typeof(TweenTMPTextBehaviour))]
    public sealed class TweenTMPTextBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "color", "fontSize", "characterSpacing", "lineSpacing", "wordSpacing", "paragraphSpacing", "colorGradient", "text"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}