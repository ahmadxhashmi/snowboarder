# 🏂 Snow Boarder

A fast-paced 2D physics-based snowboarding game built in **Unity 6** using the **Universal Render Pipeline (URP 2D)**.

---

## 🎮 Gameplay & Features

- **Physics-Based Mechanics:** Dynamic snowboard movement driven by Unity's 2D physics engine, utilizing `Rigidbody2D` and `SurfaceEffector2D` for smooth slope navigation.
- **Air Control & Flips:** Control rotation in mid-air to balance your boarder and land smoothly on snowy slopes.
- **Speed Boost:** Accelerate down the mountain for high-speed runs and bigger airtime.
- **Particle & Visual FX:**
  - Dynamic snow spray particle effects when carving along the ground.
  - Crash effects when landing improperly.
  - Finish line celebration particle effects upon completing the course.
- **Level Reset & Hazard System:** Crash detection triggers an automatic level reload when hitting obstacles or landing on your head.

---

## 🕹️ Controls

| Action | Key / Input |
| :--- | :--- |
| **Lean Backward / Rotate Left** | `A` |
| **Lean Forward / Rotate Right** | `D` |
| **Speed Boost** | `W` |

---

## 🛠️ Project Structure & Tech Stack

- **Engine Version:** Unity `6000.3.23f1` (Unity 6)
- **Render Pipeline:** Universal Render Pipeline (URP) 2D
- **Key Scripts (`Assets/Scripts/`):**
  - [`PlayerController.cs`](Assets/Scripts/PlayerController.cs): Handles torque rotation, input detection, and slope boost acceleration via `SurfaceEffector2D`.
  - [`Crashdetector.cs`](Assets/Scripts/Crashdetector.cs): Detects head impacts and collisions, disables controls, triggers crash particles, and restarts the run.
  - [`FinishLine.cs`](Assets/Scripts/FinishLine.cs): Detects player completion, triggers finish line particles, and loops the level.
  - [`SkateAnimation.cs`](Assets/Scripts/SkateAnimation.cs): Toggles the snow-spray particle system on and off depending on contact with the ground.

---

## 🚀 Getting Started

1. **Clone the repository:**
   ```bash
   git clone https://github.com/ahmadxhashmi/snowboarder.git
   ```
2. **Open in Unity Hub:**
   - Launch Unity Hub.
   - Click **Add** -> **Add project from disk**.
   - Select the cloned `snowboarder` folder.
   - Ensure you are using **Unity 6 (6000.3.23f1)** or a compatible version.
3. **Play:**
   - Open `Assets/Scenes/SampleScene.unity`.
   - Press the **Play** button in the Unity Editor toolbar.

---

## 📄 License

This project is created for educational and personal game development purposes. Feel free to use and modify it!
