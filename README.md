# Prototype 1 - Create with Code

This is **Prototype 1** from the "Create with Code" series. It is a 3D driving game where you control a vehicle on a road, avoiding obstacles and navigating a path.

## Prerequisites

- **Unity Editor**: 6000.3.7f1
- **Unity Hub**: Recommended for managing versions and project opening.

## Getting Started

Follow these steps to clone and run the project locally.

### 1. Clone the Repository

Clone this project to your local machine using Git:

```bash
git clone <your-repo-url>
cd "Prototype 1"
```

### 2. Open in Unity Hub

1.  Open **Unity Hub**.
2.  Click **Add** -> **Add project from disk**.
3.  Navigate to the `Prototype 1` folder and select it.
4.  Ensure the Unity version is set to `6000.3.7f1`.
5.  Click the project name to open it.

### 3. First-Time Setup

When you first open the project, Unity will take a few minutes to regenerate the `Library/` folder (which is ignored by Git to save space). This is normal.

1.  Go to the `Assets/Scenes/` folder.
2.  Open the **Prototype 1** scene.
3.  Press the **Play** button to start the game.

## Project Structure

- **Assets/Scripts/**: Contains the C# scripts that control game logic.
  - `PlayerController.cs`: Handles vehicle movement and input.
  - `FollowPlayer.cs`: Controls the camera movement relative to the player.
  - `RoadManager.cs`: Manages the road environment.
- **Assets/Course Library/**: Contains 3D models, textures, and materials used in the prototype.

## Controls

- **WASD / Arrow Keys**: Drive and steer the vehicle.

## License

This project is part of the Unity "Create with Code" course and is intended for educational purposes.
