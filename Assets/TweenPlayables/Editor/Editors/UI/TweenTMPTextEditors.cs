using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenTMPTextTrack))]
    public sealed class TweenTMPTextTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.uguiColor;
        public override Texture2D TrackIcon => Styling.textMeshProUGUIIcon;
        public override string DefaultTrackName => "Tween TMP_Text Track";
    }

    [CustomTimelineEditor(typeof(TweenTMPTextClip))]
    public sealed class TweenTMPTextClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween TMP_Text";
        public override Color ClipColor => Styling.uguiColor;
        public override Texture2D ClipIcon => Styling.textMeshProUGUIIcon;
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