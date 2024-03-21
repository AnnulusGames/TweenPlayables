using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenAudioSourceTrack))]
    public sealed class TweenAudioSourceTrackEditor : TweenAnimationTrackEditor
    {
        public override Color TrackColor => Styling.audioColor;
        public override Texture2D TrackIcon => Styling.audioSourceIcon;
        public override string DefaultTrackName => "Tween AudioSource Track";
    }

    [CustomTimelineEditor(typeof(TweenAudioSourceClip))]
    public sealed class TweenAudioSourceClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween AudioSource";
        public override Color ClipColor => Styling.audioColor;
        public override Texture2D ClipIcon => Styling.audioSourceIcon;
    }

    [CustomPropertyDrawer(typeof(TweenAudioSourceBehaviour))]
    public sealed class TweenAudioSourceBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "volume", "pitch"
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}