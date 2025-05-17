# Simple 2D Shooter for Unity

This repository contains a minimal example of a 2D top‑down shooter game for Unity. The code is inspired by browser shooters like **Doomed.io** or **Devast.io**, but it only implements a few core mechanics to serve as a starting point for further development.

## Features

- Player movement using WASD or arrow keys
- Shooting projectiles with the mouse button
- Basic enemy AI that follows the player
- Enemy spawning over time

## Getting Started

1. Create a new Unity 2D project.
2. Copy the `Assets` folder from this repository into your Unity project.
3. Create simple prefabs for the player, projectile and enemy objects and assign the corresponding scripts:
   - `PlayerController` to the player prefab
   - `Projectile` to the projectile prefab
   - `EnemyController` to the enemy prefab
   - Add a `GameManager` object to the scene and assign the enemy prefab reference
4. Mark the player object with the tag `Player` so enemies can find it.
5. Run the scene to test.

This setup provides a very small foundation. To get something closer to the full mechanics of the referenced games you would need to implement additional systems such as resource gathering, crafting, health bars, multiplayer and more.

Contributions are welcome!
