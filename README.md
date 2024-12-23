# Aircraft Field

## 📖 Table of Contents
1. [About](#-about)
2. [How to Play](#-how-to-play)
3. [Download Game](#-download-game)
4. [Scripts and Features](#-scripts-and-features)
5. [Developer](#-developer)
6. [File Description](#-file-description)
7. [Assets Link](#-assets-link)

---

## 🎮 About

**Aircraft Field** is an endless arcade-style shooter game where players face a constant wave of enemies. The objective is to destroy enemies and collect the coins they drop to achieve the highest score. Bullets are fired automatically, allowing the player to focus on movement and strategy.

---

## 🕹️ How to Play
1. **Objective**: Destroy enemies, collect coins, and survive as long as possible to achieve the highest score!
2. **Controls**:
   - **WASD**: Move the player character.
3. **Gameplay Tip**: Keep moving to avoid enemies and collect coins quickly before they disappear.

---

## 📥 Download Game

Click the link below to download **2D Top-Down Shooter**:  
[Download 2D Top-Down Shooter](https://drive.google.com/drive/folders/11J3UDdVZ1huwo3TEXZ05vhM3BCWjFuLX?usp=sharing)

---

## 📜 Scripts and Features

Below is a list of the main scripts in the game, each contributing to core gameplay mechanics:

|  Script            | Description                                                  |
| ------------------- | ------------------------------------------------------------ |
| `BackgroundLooper.cs` | Handles the infinite scrolling of the background for a seamless gameplay experience. |
| `EnemySpawner.cs`     | Continuously spawns enemies with increasing difficulty over time. |
| `EnemyMovement.cs`    | Controls enemy movement, which either follows a random pattern or targets the player. |
| `ControlInput.cs`     | Manages player movement using the WASD keys. |
| `PlayerMovement.cs`   | Handles the player's movement and ensures the player remains within the game boundaries. |
| `ScoreCounter.cs`     | Tracks and updates the player's score based on the coins collected. |

---

## 👤 Developer

**Nathanael Chendra Rusli**

---

## 📂 File Description

```
├── TowerDefense                      # Contain everything needed for Modern Assault Defense to works.
   ├── Assets                         # Contains every assets that have been worked with unity to create the game like the scripts and the art.
      ├── Assets                      # Contains all the game art like the sprites, prefab, background, even font.
      ├── Script                      # Contains all scripts needed to make the gane get goings like PlayerMovement scripts.
      ├── Scenes                      # Contains all scenes that exist in the game for it to interconnected with each other like MainMenu, Gameplay, etc
      ├── ThirdParty Packages         # Contains the Package Manager from unity registry or unity asset store assets for game purposes.
   ├── Packages                       # Contains game packages that responsible for managing external libraries and packages used in your project.
      ├── Manifest.json               # Contains the lists of all the packages that your project depends on and their versions.
      ├── Packages-lock.json          # Contains packages that ensuring your project always uses the same versions of all dependencies and their sub-dependencies.
   ├── Project Settings               # Contains the configuration of your game to control the quality settings, icon, or even the cursor settings
```

## 🌐 Assets Link
- https://kenney-assets.itch.io/pixel-shmup
