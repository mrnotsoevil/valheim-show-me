# Valheim, Show me!

A simple mod that shows you on the map by default.

## Installation

1. Install [Valheim BepInEx](https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim/)
2. Copy `valheim_show_me.dll` (in the ZIP file) into `Valheim/BepInEx/plugins`

## Compiling the plugin

The `valheim-no-wear-and-tear/libs` folder should contain following DLLs:

* 0Harmony.dll (from BepInEx)
* BepInEx.dll (from BepInEx)
* BepInEx.Harmony.dll (from BepInEx)
* UnityEngine.dll (from BepInEx)
* UnityEngine.CoreModule.dll (from BepInEx)
* assembly_valheim.dll (from Valheim managed directory)

You can use Visual Studio or Jetbrains Rider.

## Harmony patch information

* Patches `Awake` in `ZNet` (Postfix)
