# Tween Playables
Tween Animation Library for Unity Timeline

<img src="https://github.com/AnnulusGames/TweenPlayables/blob/main/Assets/TweenPlayables/Documentation~/Header.png" width="800">

[![license](https://img.shields.io/badge/LICENSE-MIT-green.svg)](LICENSE)

[日本語版READMEはこちら](README_JP.md)

## Overview
Tween Playables is a library that adds tween animation tracks to Unity Timeline. It adds tracks for a variety of components, making it possible to quickly and easily build complex tweens in your timeline.

### Features

<img src="https://github.com/AnnulusGames/TweenPlayables/blob/main/Assets/TweenPlayables/Documentation~/sample.gif" width="800">

* Add tracks for tween animation
* More than 20 types of easing functions available
* All clips can be blended
* Simple and easy to use GUI


## Setup

### Requirement
* Unity 2020.1 or higher
* Timeline 1.2.14 or higher
* TextMeshPro 2.0.1 or higher

### Install
1. Open the Package Manager from Window > Package Manager
2. "+" button > Add package from git URL
3. Enter the following to install
   * https://github.com/AnnulusGames/TweenPlayables.git?path=/Assets/TweenPlayables


or open Packages/manifest.json and add the following to the dependencies block.

```json
{
    "dependencies": {
        "com.annulusgames.tween-playables": "https://github.com/AnnulusGames/TweenPlayables.git?path=/Assets/TweenPlayables"
    }
}
```

## Usage

<img src="https://github.com/AnnulusGames/TweenPlayables/blob/main/Assets/TweenPlayables/Documentation~/img1.png" width="350">

1. Select "AnnulusGames.TweenPlayables" item from the "+" button and add a track corresponding to the component you want to control.
2. Right click > Select "Add Tween *** Clip" to add the clip to the track.
3. Set the clip values from the Inspector.

## Parameter Settings

<img src="https://github.com/AnnulusGames/TweenPlayables/blob/main/Assets/TweenPlayables/Documentation~/img2.png" width="350">

#### Toggle
Whether to control that parameter. If checked, animation for that parameter will be enabled.

#### Start / End
Sets the start/end value of the animation.

#### Ease
Set the easing function. You can also set your own easing from the Animation Curve by selecting "Custom".

#### Relative
Whether to use relative values. If checked, the start/end values will be relative values from the start of the animation.

## Controllable Components

|Conponent|Parameter|
|-|-|
|<b>Transform</b>|Position<br>Rotation<br>Scale|
|<b>Renderer</b>|Color<br>Texture Offset<br>Texture Scale|
|<b>Sprite Renderer</b>|Color|
|<b>Line Renderer</b>|Start Color<br>End Color<br>Start Width<br>End Width|
|<b>Camera</b>|Orthographic Size<br>Field of View<br>Background Color|
|<b>Audio Source</b>|Volume<br>Pitch|
|<b>Light</b>|Color<br>Intensity<br>Shadow Strength|
|<b>RectTransform</b>|Anchored Position<br>Size Delta<br>Rotation<br>Scale|
|<b>Canvas Group</b>|Alpha|
|<b>Graphic</b>|Color|
|<b>Text</b>|Color<br>Font Size<br>Line Spacing|
|<b>TextMeshProUGUI</b>|Font Size<br>Color<br>Color Gradient<br>Spacing (Character, Line, Word, Paragraph)|
|<b>Image</b>|Color<br>Fill Amount|
|<b>Slider</b>|Value|
|<b>Outline</b>|Color<br>Distance|
|<b>Shadow</b>|Color<br>Distance|

## Known Issues

### Error "DrivenPropertyManager has failed to~"

Some components may produce an error "DrivenPropertyManager has failed to register property "PropertyName" of object "Object Name" with driver "" because the property doesn't exist."

This error is due to the behavior of the DrivenPropertyManager and does not occur at runtime. Since it is an error related to property registration to the last, it does not seem to have a big impact on the project.

A thread related to this issue can be found here.
https://forum.unity.com/threads/default-playables-text-switcher-track-error.502903/

## License

[MIT License](LICENSE)
