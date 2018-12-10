ShinyEffectForTMPro
===

### NOTE: This project is experimental.
### NOTE: This project is a derivative project of [MeshEffectForTextMeshPro](https://github.com/mob-sakai/MeshEffectForTextMeshPro).
### NOTE: This project will be integrated to [UIEffect](https://github.com/mob-sakai/UIEffect).

ShinyEffectForTMPro provide shiny effect component for TextMeshPro in Unity.

![](https://user-images.githubusercontent.com/12690315/49693817-ba23c880-fbc0-11e8-869f-f0853010b609.png)

[![](https://img.shields.io/github/release/mob-sakai/ShinyEffectForTMPro.svg?label=latest%20version)](https://github.com/mob-sakai/ShinyEffectForTMPro/releases)
[![](https://img.shields.io/github/release-date/mob-sakai/ShinyEffectForTMPro.svg)](https://github.com/mob-sakai/ShinyEffectForTMPro/releases)
![](https://img.shields.io/badge/unity-5.6%2B-green.svg)
[![](https://img.shields.io/github/license/mob-sakai/ShinyEffectForTMPro.svg)](https://github.com/mob-sakai/ShinyEffectForTMPro/blob/master/LICENSE.txt)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-orange.svg)](http://makeapullrequest.com)

<< [Description](#Description) | [WebGL Demo](#demo) | [Download](https://github.com/mob-sakai/ShinyEffectForTMPro/releases) | [Usage](#usage) | [Example of using](#example-of-using) | [Development Note](#development-note) | [Change log](https://github.com/mob-sakai/ShinyEffectForTMPro/blob/master/CHANGELOG.md) >>

### What's new? [See changelog ![](https://img.shields.io/github/release-date/mob-sakai/ShinyEffectForTMPro.svg?label=last%20updated)](https://github.com/mob-sakai/ShinyEffectForTMPro/blob/develop/CHANGELOG.md)
### Do you want to receive notifications for new releases? [Watch this repo ![](https://img.shields.io/github/watchers/mob-sakai/ShinyEffectForTMPro.svg?style=social&label=Watch)](https://github.com/mob-sakai/ShinyEffectForTMPro/subscription)



<br><br><br><br>
## Description

ShinyEffectForTMPro provide shiny effect component (from [UIEffect](https://github.com/mob-sakai/UIEffect)) for TextMeshPro in Unity.

It works well not only for standard Graphic components (Image, RawImage, Text, etc.) but also for TextMeshPro and TextMeshProUGUI.

![](https://user-images.githubusercontent.com/12690315/49694176-6b7a2c80-fbc8-11e8-9461-c3595736b4d5.png)
![](https://user-images.githubusercontent.com/12690315/49694175-69b06900-fbc8-11e8-9615-e675822decf3.png)


#### Features

* Rotation, width, softness, brightness and gloss of shiny effect.
* Effect area: RectTransform, Fit, Split by character.
* Support `<font>` and `<sprite>` tags.
* You can control effect properties from script, AnimationClip and inspector.
* Works well not only for standard Graphic components (Image, RawImage, Text, etc.) but also for TextMeshPro and TextMeshProUGUI.
* No useless allocation.
* Easy to set up.



<br><br><br><br>
## Demo

[WebGL Demo](http://mob-sakai.github.io/ShinyEffectForTMPro)

![](https://user-images.githubusercontent.com/12690315/49693789-34a01880-fbc0-11e8-9ef2-fa8b0e4dd438.gif)



<br><br><br><br>
## Usage

1. Download ShinyEffectForTMPro.unitypackage from [Releases](https://github.com/mob-sakai/ShinyEffectForTMPro/releases).
2. Import the package into your Unity project. Click `Import Package > Custom Package` from the `Assets` menu.  
3. Enable `TexCoord1` and `TexCoord2` channels of canvas.  
![](https://user-images.githubusercontent.com/12690315/49696625-eacf2680-fbef-11e8-9360-f597f9d4484f.png)  
![](https://user-images.githubusercontent.com/12690315/49696633-1eaa4c00-fbf0-11e8-92e5-37fa6a1e01f9.png)
1. Add UIShiny component to TextMeshPro from `Add Component` in inspector or `Component > MeshEffectForTMPro > UIShiny` menu.
2. Set shiny material preset to the TextMeshPro component. Press the Fix button to generate or set shiny material preset.  
![](https://user-images.githubusercontent.com/12690315/49694638-3e7e4780-fbd1-11e8-8c7f-4d9a2e6c365a.png)
5. (Option) Set shiny sprite asset to the TextMeshPro component. Press the Fix button to generate or set shiny sprite asset.  
![](https://user-images.githubusercontent.com/12690315/49694647-535adb00-fbd1-11e8-8bea-7a64fdf00de0.png)
6.  Adjust the parameters of the effect as you like, in inspector.  
![](https://user-images.githubusercontent.com/12690315/49696677-e0615c80-fbf0-11e8-98f5-c60890915129.gif)
7.  Enjoy!



##### Requirement

* Unity 5.6+ *(including Unity 2019.x)*
* TextMeshPro v1.0.0+



<br><br><br><br>
## Development Note



<br><br><br><br>
## License

* MIT
* © UTJ/UCL



## Author

[mob-sakai](https://github.com/mob-sakai)



## See Also

* GitHub page : https://github.com/mob-sakai/ShinyEffectForTMPro
* Releases : https://github.com/mob-sakai/ShinyEffectForTMPro/releases
* Issue tracker : https://github.com/mob-sakai/ShinyEffectForTMPro/issues
* Current project : https://github.com/mob-sakai/ShinyEffectForTMPro/projects/1
* Change log : https://github.com/mob-sakai/ShinyEffectForTMPro/blob/master/CHANGELOG.md
