# The Reckoning: Salvage Analysis & Pivot Strategy

## Executive Summary
Despite the corruption of the main Unity project that grew to be 35G big, I have managed to succesfully recover **44 C# scripts** from "The Reckoning", which are thousands of lines of functional code across 9 major game systems. These scripts, dated November 4, 2021, showcase a well executed multiplayer horror FPS with advanced features that can be repurposed into multiple standalone projects and educational resources.

## What Was Recovered

### Core Systems Overview
- **Total Scripts:** 44 files
- **Development Period:** Active as of November 2021
- **Project Scope:** Multiplayer horror FPS with advanced mechanics
- **Estimated Original Codebase:** 100+ KB of C# code

### System Breakdown by Category

#### 1. Core Gameplay (7 files)
- `PlayerMovement.cs` (25 KB) - Comprehensive FPS controller
- `Health.cs` (7 KB) - Player health and damage system  
- `Weapon.cs` (13 KB) - Complete weapon system with shooting mechanics
- `RaycastCombat.cs` - Hit detection and combat mechanics
- `GameManager.cs` - Central game state management
- `SpawnManager.cs` & `Spawnpoint.cs` - Player spawning system

#### 2. Networking/Multiplayer (7 files)
- `Launcher.cs` (11 KB) - Multiplayer lobby and connection system
- `RoomManager.cs` (6 KB) - Multiplayer room management
- `PlayerManager.cs` - Player instance management
- `NetworkChecker.cs` & `InternetConnection.cs` - Connection validation
- `ServerNameButton.cs` & `UserNameList.cs` - UI networking components

#### 3. Advanced Movement & Camera (3 files)
- `WallRun [Redacted].cs` (7 KB) - Advanced parkour mechanics
- `RTSCam.cs` (11 KB) - Sophisticated camera system
- `MoveCamera.cs` - Camera movement utilities

#### 4. Item/Inventory System (4 files)
- `ItemManager.cs` (22 KB) - Complex inventory and item handling
- `Item.cs`, `ItemInfo.cs`, `GunInfo.cs` - Item data structures

#### 5. Visual Effects & Polish (8 files)
- `WeaponBobbing.cs` & `WeaponSway.cs` - Realistic weapon movement
- `CamShake.cs` & `UIShake.cs` - Screen shake effects
- `Flashlight.cs` - Dynamic lighting system
- `LineFade.cs`, `Billboard.cs`, `AutoRotate.cs` - Visual utilities

#### 6. UI/UX Systems (8 files)
- `PauseMenu.cs` (5 KB) - Complete pause menu system
- `GameUI.cs` - HUD and game interface
- `LoadingScreen.cs` & `LoadHomeScreen.cs` - Scene transitions
- `NameTag.cs` & `PlayerNameTag.cs` - Player identification
- `CrossHairTarget.cs` - Targeting system

#### 7. Audio Implementation (1 file)
- `AudioTestCode.cs` - 3D spatial audio testing framework

#### 8. Scene Management (4 files)
- `TransitionLeave.cs` & `TransitionQuit.cs` - Scene transitions
- `BackgroundMove.cs` & `Offline.cs` - Environment and state management

#### 9. Damage System (2 files)
- `BurnDamage.cs` - Environmental damage mechanics
- `IDamageable.cs` - Damage interface for modular design

### Horror-Specific Elements
- `Flashlight.cs` - Dynamic lighting for horror atmosphere
- `BurnDamage.cs` - Environmental hazards
- `CamShake.cs` - Tension-building screen effects
- Audio spatializer integration for 3D horror sound

## Conclusion

While "The Reckoning" as a complete game may be lost even before it was seen, its legacy lives. 44 well-architected (well mostly) Scripts were salvaged. I'd say great success!

---

This README will be updated along with the project progress which would be a bit slow considering other priorities. or you can read my [blog](https://ujjwalvivek.com/blog) (when it goes live :))

---