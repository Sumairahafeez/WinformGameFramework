# Zombie Survival Game

Welcome to **Survive the Horde: Zombie Apocalypse** - a thrilling adventure that throws you into a world overrun by zombies. Armed with your wits and an arsenal of weapons, your mission is simple: fight through waves of zombies, scavenge for supplies, and stay alive at all costs. But beware, the undead hordes grow stronger with each passing moment, and danger lurks around every corner. Do you have what it takes to survive and emerge victorious?

## Introduction

**Survive the Horde: Zombie Apocalypse** is a project developed as part of the CSC-103 Object-Oriented Programming course at the University of Engineering and Technology, Lahore, Pakistan. This project demonstrates the implementation of Object-Oriented Programming (OOP) concepts in a game framework.

## OOP Concepts

The game incorporates the following OOP principles:

1. **Inheritance**: Implemented through interfaces where classes inherit common functionality, such as movement and collision detection.

2. **Polymorphism**: Demonstrated in various functions across classes, allowing for flexibility in behavior based on object types.

3. **Interfaces**: Utilized to define contracts for movement and collision detection, enabling different implementations for distinct game objects.

## Classes

The game framework consists of the following classes:

1. **Game**: The main class facilitating the addition and management of game objects.
2. **GameObject**: Represents entities within the game, such as players, enemies, and bullets.
3. **Movement Classes**: Including `VerticalMovement`, `HorizontalMovement`, and `ZigZagMovement`, implementing different types of movements.
4. **Collision Classes**: Responsible for detecting collisions between game objects.
5. **Enum**: Defines enumerations for directions, actions, and object types.

## Wireframes

- **Start Page**: The initial screen displaying the game title and options to start or exit.
- **Game Menu**: Allows players to access game settings, instructions, or resume gameplay.
- **Game Over Page**: Displays when the player's health reaches zero, indicating the end of the game.

## Game Rules

1. **Player-Enemy Collision**: Contact with enemies reduces the player's health.
2. **Bullet-Zombie Interaction**: Bullets eliminate zombies upon contact.
3. **Objective**: Players must eliminate all enemies to progress to the next level or win the game.
4. **Health**: If the player's health depletes without defeating enemies, the game ends.
5. **Enemy Variance**: Some enemies may require multiple bullets to eliminate.


## Code

The game framework comprises several C# classes, each fulfilling specific roles:

- **Game Class**: Manages game objects, updates their positions, and handles collisions.
- **GameObject Class**: Represents entities in the game, encapsulating attributes and behaviors.
- **Movement Classes**: Define movement behaviors for different game objects.
- **Collision Classes**: Detect collisions between game entities and trigger appropriate actions.
- **Factory Pattern**: Implements a factory pattern to manage the creation of game objects and enforce limits.

For detailed code implementation, please refer to the provided C# files.

## Contribution

This project was submitted by Sumaira Hafeez under the supervision of Sir Dr. Awais Hassan at the University of Engineering and Technology, Lahore, Pakistan.

For any inquiries or contributions, please contact:

- Sumaira Hafeez: [email@example.com](mailto:sumairahafeezfp@gmail.com)


---

