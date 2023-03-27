using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEditor;
using UnityEditor.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    public abstract class TweenAnimationTrackEditor : TrackEditor
    {
        public abstract string defaultTrackName { get; }
        public abstract Color trackColor { get; }
        public abstract Texture2D trackIcon { get; }

        public override TrackDrawOptions GetTrackOptions(TrackAsset track, Object binding)
        {
            var options = base.GetTrackOptions(track, binding);
            options.trackColor = trackColor;
            options.icon = trackIcon;
            return options;
        }

        public override void OnCreate(TrackAsset track, TrackAsset copiedFrom)
        {
            track.name = defaultTrackName;
        }
    }

}