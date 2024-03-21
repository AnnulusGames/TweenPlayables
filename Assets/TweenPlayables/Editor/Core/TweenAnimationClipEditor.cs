using UnityEngine;
using UnityEditor.Timeline;
using UnityEngine.Timeline;

namespace TweenPlayables.Editor
{
    public abstract class TweenAnimationClipEditor : ClipEditor
    {
        public abstract Color ClipColor { get; }
        public abstract Texture2D ClipIcon { get; }
        public abstract string DefaultClipName { get; }

        public override ClipDrawOptions GetClipOptions(TimelineClip clip)
        {
            var options = base.GetClipOptions(clip);
            options.icons = new Texture2D[] { ClipIcon };
            options.highlightColor = ClipColor;
            return options;
        }

        public override void OnCreate(TimelineClip clip, TrackAsset track, TimelineClip clonedFrom)
        {
            clip.displayName = DefaultClipName;
        }
    }
}
