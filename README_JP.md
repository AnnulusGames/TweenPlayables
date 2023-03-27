# Tween Playables
Tween Animation Library for Unity Timeline

<img src="https://github.com/AnnulusGames/TweenPlayables/blob/main/Assets/TweenPlayables/Documentation~/Header.png" width="800">

[![license](https://img.shields.io/badge/LICENSE-MIT-green.svg)](LICENSE)

[English README](README.md)

## 概要
Tween PlayablesはUnityのTimelineにトゥイーンアニメーションの機能を追加するライブラリです。様々なコンポーネントに対応したトラックが追加され、複雑なイージングをTimeline上で素早く簡単に構築することが可能になります。

### 特徴

<img src="https://github.com/AnnulusGames/TweenPlayables/blob/main/Assets/TweenPlayables/Documentation~/sample.gif" width="800">

* トゥイーンアニメーション用のトラックを追加
* 多くのコンポーネントに対応
* 30種類以上のイージング関数を用意
* 全てのクリップがブレンド可能
* シンプルで扱いやすいGUI

## セットアップ

### 要件
* Unity 2020.1 以上
* Timeline 1.2.14 以上
* TextMeshPro 2.0.1 以上

### インストール
1. Window > Package ManagerからPackage Managerを開く
2. 「+」ボタン > Add package from git URL
3. 以下を入力する
   * https://github.com/AnnulusGames/TweenPlayables.git?path=/Assets/TweenPlayables


あるいはPackages/manifest.jsonを開き、dependenciesブロックに以下を追記

```json
{
    "dependencies": {
        "com.annulusgames.tween-playables": "https://github.com/AnnulusGames/TweenPlayables.git?path=/Assets/TweenPlayables"
    }
}
```

## 使い方

<img src="https://github.com/AnnulusGames/TweenPlayables/blob/main/Assets/TweenPlayables/Documentation~/img1.png" width="350">

1. 「+」ボタンからAnnulusGames.TweenPlayablesの項目を選び、操作したいコンポーネントに対応したトラックを追加します。
2. 右クリック >「Add Tween *** Clip」を選択し、トラックにクリップを追加します。
3. Inspectorからクリップの値を設定します。

## パラメーターの設定

<img src="https://github.com/AnnulusGames/TweenPlayables/blob/main/Assets/TweenPlayables/Documentation~/img2.png" width="350">

#### チェックボックス
そのパラメーターを操作するかどうか。チェックを入れた場合、そのパラメーターのアニメーションが有効化されます。

#### Start / End
アニメーションの開始値/終了値を設定します。

#### Ease
イージング関数を設定します。Customを選択することでAnimation Curveから独自のイージングを設定することも可能です。

#### Relative
相対値を利用するかどうか。チェックを入れた場合、開始値/終了値はアニメーション開始時からの相対的な値になります。

## 操作可能なコンポーネント

|コンポーネント|パラメーター|
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

## 既知の問題

### DrivenPropertyManager has failed to~ というエラーが表示される

一部のコンポーネントで "DrivenPropertyManager has failed to register property "PropertyName" of object "Object Name" with driver "" because the property doesn't exist."というエラーが発生することがあります。

このエラーはDrivenPropertyManagerの動作によるもので、ランタイムでは発生しません。あくまでプロパティの登録に関するエラーであるため、プロジェクトへの大きな影響はないと思われます。

この問題に関連するスレッドはこちらで確認できます。
https://forum.unity.com/threads/default-playables-text-switcher-track-error.502903/

## ライセンス

[MIT License](LICENSE)
