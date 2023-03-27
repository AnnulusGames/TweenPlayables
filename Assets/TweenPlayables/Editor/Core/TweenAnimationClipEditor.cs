using UnityEngine;
using UnityEditor.Timeline;
using UnityEngine.Timeline;

namespace AnnulusGames.TweenPlayables.Editor
{
    public abstract class TweenAnimationClipEditor : ClipEditor
    {
        public abstract Color clipColor { get; }
        public abstract Texture2D clipIcon { get; }
        public abstract string defaultClipName { get; }

        private Texture2D[] icons = new Texture2D[1];

        public override ClipDrawOptions GetClipOptions(TimelineClip clip)
        {
            var options = base.GetClipOptions(clip);
            icons[0] = clipIcon;
            options.icons = icons;
            options.highlightColor = clipColor;
            return options;
        }

        public override void OnCreate(TimelineClip clip, TrackAsset track, TimelineClip clonedFrom)
        {
            clip.displayName = defaultClipName;
        }
    }
}
