<h1 align="center">Jailbird Charge Blocker</h1>
<div align="center">
<a href="https://github.com/MS-crew/JailbirdChargeBlocker"><img src="https://img.shields.io/github/actions/workflow/status/Exiled-Team/EXILED/main.yml?style=for-the-badge&logo=githubactions&label=build" href="https://github.com/MS-crew/JailbirdChargeBlocker" alt="GitHub Source Code"></a>
<a href="https://github.com/MS-crew/JailbirdChargeBlocker/releases"><img src="https://img.shields.io/github/downloads/MS-crew/JailbirdChargeBlocker/total?style=for-the-badge&logo=githubactions&label=Downloads" href="https://github.com/MS-crew/JailbirdChargeBlocker/releases" alt="GitHub Release Download"></a>
<a href="https://github.com/MS-crew/JailbirdChargeBlocker/releases"><img src="https://img.shields.io/badge/Build-1.1.0-brightgreen?style=for-the-badge&logo=gitbook" href="https://github.com/MS-crew/JailbirdChargeBlocker/releases" alt="GitHub Releases"></a>
<a href="https://github.com/MS-crew/JailbirdChargeBlocker/blob/master/LICENSE"><img src="https://img.shields.io/badge/Licence-GNU_3.0-blue?style=for-the-badge&logo=gitbook" href="https://github.com/MS-crew/JailbirdChargeBlocker/blob/master/LICENSE" alt="General Public License v3.0"></a>
<a href="https://github.com/ExMod-Team/EXILED"><img src="https://img.shields.io/badge/Exiled-8.12.2-red?style=for-the-badge&logo=gitbook" href="https://github.com/ExMod-Team/EXILED" alt="GitHub Exiled"></a>

</div>

## Jailbird Charge blocker

- **Jailbird Charge block:** With this plugin, jailbird does not charge, even the animation does not activate, right click does not work.
- **Jailbird Attack block (adjustable):** If you want jailbird not to cause damage for rp, with this option jailbird will not do real damage, it will only hit apparently.
- **Unbreakeble Jailbird (adjustable):** In the normal game, Jailbird will be broken in 5 hits by shaking it, but with this setting it will not break.

## Installation

1. Download the release file from the GitHub page [here](https://github.com/MS-crew/JailbirdChargeBlocker/releases).
2. Extract the contents into your `\AppData\Roaming\EXILED\Plugins` directory.
3. Configure the plugin according to your server’s needs using the provided settings.
4. Restart your server to apply the changes.

## Feedback and Issues

This is the initial release of the plugin. We welcome any feedback, bug reports, or suggestions for improvements.

- **Report Issues:** [Issues Page](https://github.com/MS-crew/JailbirdChargeBlocker/issues)
- **Contact:** [discerrahidenetim@gmail.com](mailto:discerrahidenetim@gmail.com)

Thank you for using our plugin and helping us improve it!
## Default Config
```yml
IsEnabled { get; set; } = true;
Debug { get; set; } = false;
Damage { get; set; } = true;
UnbreakebleJail { get; set; } = true;
```
