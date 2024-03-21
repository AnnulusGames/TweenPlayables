using UnityEngine;
using UnityEngine.Timeline;
using UnityEditor.Timeline;

namespace TweenPlayables.Editor
{
    public abstract class TweenAnimationTrackEditor : TrackEditor
    {
        public abstract string DefaultTrackName { get; }
        public abstract Color TrackColor { get; }
        public abstract Texture2D TrackIcon { get; }

        public override TrackDrawOptions GetTrackOptions(TrackAsset track, Object binding)
        {
            var options = base.GetTrackOptions(track, binding);
            options.trackColor = TrackColor;
            options.icon = TrackIcon;
            return options;
        }

        public override void OnCreate(TrackAsset track, TrackAsset copiedFrom)
        {
            track.name = DefaultTrackName;
        }
    }
}