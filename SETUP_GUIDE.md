# Sword Slayer Setup Guide

This guide will walk you through the step-by-step process of setting up the Sword Slayer game in Unity with a virtual joystick for mobile, prefab configurations, scene setup, and all component connections.

## Table of Contents
1. [Requirements](#requirements)
2. [Setting up Unity](#setting-up-unity)
3. [Importing the Project](#importing-the-project)
4. [Configuring the Virtual Joystick](#configuring-the-virtual-joystick)
5. [Prefab Configurations](#prefab-configurations)
6. [Scene Setup](#scene-setup)
7. [Component Connections](#component-connections)
8. [Testing the Game](#testing-the-game)

## Requirements
- Unity 2020 or later
- Unity Remote (optional for testing on mobile)

## Setting up Unity
1. Download and install Unity Hub.
2. Create a new Unity project using the 3D template.

## Importing the Project
1. Clone the Sword Slayer repository from GitHub:
   ```bash
   git clone https://github.com/<owner>/Sword-slayer-
   cd Sword-slayer-
   ```
2. Open the project in Unity by selecting the folder where the project was cloned.

## Configuring the Virtual Joystick
1. Import the virtual joystick package (if provided).
2. In the Hierarchy, create a new Canvas:
   - Right-click in Hierarchy > UI > Canvas.
3. Add the virtual joystick prefab to the Canvas:
   - Drag and drop the joystick prefab onto the Canvas in the Hierarchy.
4. Adjust position and scaling for mobile view as needed.

## Prefab Configurations
1. Locate the prefab directory within the project.
2. Customize prefabs (e.g., characters, enemies, items):
   - Select a prefab in the Project panel.
   - Edit properties in the Inspector.
3. Ensure all required components are attached to the prefabs.

## Scene Setup
1. Open the main scene where you want to implement the game logic.
2. Organize your scene:
   - Add terrain, lighting, and a skybox as needed.
   - Position your player prefab at the start position.

## Component Connections
1. Select your player prefab in the Hierarchy.
2. In the Inspector, connect the virtual joystick to the player movement script:
   - Drag the joystick object into the movement script field.
3. Connect other components as required (e.g., UI elements, camera).

## Testing the Game
1. If using Unity Remote, connect your mobile device and enable remote settings.
2. Click the Play button in Unity to test the game in the editor.
3. Test on mobile devices for performance and usability.

---

This guide will help you successfully set up the Sword Slayer game in Unity. For further queries, please refer to the documentation or contact the support team.