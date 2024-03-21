using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    [CustomTimelineEditor(typeof(TweenCameraTrack))]
    public sealed class TweenCameraTrackEditor : TweenAnimationTrackEditor
    {
        public override string DefaultTrackName => "Tween Camera Track";
        public override Color TrackColor => Styles.CameraColor;
        public override Texture2D TrackIcon => Styles.cameraIcon;
    }

    [CustomTimelineEditor(typeof(TweenCameraClip))]
    public sealed class TweenCameraClipEditor : TweenAnimationClipEditor
    {
        public override string DefaultClipName => "Tween Camera";
        public override Color ClipColor => Styles.CameraColor;
        public override Texture2D ClipIcon => Styles.cameraIcon;
    }

    [CustomPropertyDrawer(typeof(TweenCameraBehaviour))]
    public sealed class TweenCameraBehaviourDrawer : TweenAnimationBehaviourDrawer
    {
        static readonly string[] parameters = new string[]
        {
            "fieldOfView", "orthographicSize", "backgroundColor",
        };

        protected override IEnumerable<string> GetPropertyNames() => parameters;
    }
}