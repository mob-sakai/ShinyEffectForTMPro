ShinyEffectForTMPro
===

### NOTE: This project is experimental.
### NOTE: This project is a derivative project of [MeshEffectForTextMeshPro](https://github.com/mob-sakai/MeshEffectForTextMeshPro).
### NOTE: This project will be integrated to [UIEffect](https://github.com/mob-sakai/UIEffect).

ShinyEffectForTMPro provide shiny effect component for TextMeshPro in Unity.

![](https://user-images.githubusercontent.com/12690315/49728596-8c20b000-fcb6-11e8-87fa-e27eb6a90602.gif)

[![](https://img.shields.io/github/release/mob-sakai/ShinyEffectForTMPro.svg?label=latest%20version)](https://github.com/mob-sakai/ShinyEffectForTMPro/releases)
[![](https://img.shields.io/github/release-date/mob-sakai/ShinyEffectForTMPro.svg)](https://github.com/mob-sakai/ShinyEffectForTMPro/releases)
![](https://img.shields.io/badge/unity-5.6%2B-green.svg)
[![](https://img.shields.io/github/license/mob-sakai/ShinyEffectForTMPro.svg)](https://github.com/mob-sakai/ShinyEffectForTMPro/blob/master/LICENSE.txt)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-orange.svg)](http://makeapullrequest.com)

<< [Description](#Description) | [WebGL Demo](#demo) | [Download](https://github.com/mob-sakai/ShinyEffectForTMPro/releases) | [Usage](#usage) | [Development Note](#development-note) | [Change log](https://github.com/mob-sakai/ShinyEffectForTMPro/blob/master/CHANGELOG.md) >>

### What's new? [See changelog ![](https://img.shields.io/github/release-date/mob-sakai/ShinyEffectForTMPro.svg?label=last%20updated)](https://github.com/mob-sakai/ShinyEffectForTMPro/blob/develop/CHANGELOG.md)
### Do you want to receive notifications for new releases? [Watch this repo ![](https://img.shields.io/github/watchers/mob-sakai/ShinyEffectForTMPro.svg?style=social&label=Watch)](https://github.com/mob-sakai/ShinyEffectForTMPro/subscription)



<br><br><br><br>
## Description

ShinyEffectForTMPro provide shiny effect component (from [UIEffect](https://github.com/mob-sakai/UIEffect)) for TextMeshPro in Unity.

It works well not only for standard Graphic components (Image, RawImage, Text, etc.) but also for TextMeshPro and TextMeshProUGUI.

![](https://user-images.githubusercontent.com/12690315/49728715-d86bf000-fcb6-11e8-8722-5f2b1e63ef34.png)


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

![](https://user-images.githubusercontent.com/12690315/49728849-34367900-fcb7-11e8-83f7-f8bd23fe28e3.gif)



<br><br><br><br>
## Usage

1. Download ShinyEffectForTMPro.unitypackage from [Releases](https://github.com/mob-sakai/ShinyEffectForTMPro/releases).
2. Import the package into your Unity project. Click `Import Package > Custom Package` from the `Assets` menu.  
3. Enable `TexCoord1` and `TexCoord2` channels of canvas.  
![](https://user-images.githubusercontent.com/12690315/49696625-eacf2680-fbef-11e8-9360-f597f9d4484f.png)  
![](https://user-images.githubusercontent.com/12690315/49728477-3b10bc00-fcb6-11e8-988d-24044866e888.png)
4. Add UIShiny component to TextMeshPro from `Add Component` in inspector or `Component > MeshEffectForTMPro > UIShiny` menu.
5. Set shiny material preset to the TextMeshPro component. Press the Fix button to generate or set shiny material preset.  
![](https://user-images.githubusercontent.com/12690315/49728471-377d3500-fcb6-11e8-849b-d664aeb9da75.png)
6. (Option) Set shiny sprite asset to the TextMeshPro component. Press the Fix button to generate or set shiny sprite asset.  
![](https://user-images.githubusercontent.com/12690315/49728474-3946f880-fcb6-11e8-9668-778e07e60fe6.png)
7.  Adjust the parameters of the effect as you like, in inspector.  
![](https://user-images.githubusercontent.com/12690315/49696677-e0615c80-fbf0-11e8-98f5-c60890915129.gif)
8.  Enjoy!



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
