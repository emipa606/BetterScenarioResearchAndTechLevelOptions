# Copilot Instructions for Better Scenario Research and Tech Level Options (Continued)

Welcome to the GitHub Copilot instructions for the "Better Scenario Research and Tech Level Options" mod for RimWorld. This document provides an overview of the mod, its key features, systems, coding patterns, XML integration, and suggestions for using GitHub Copilot in the development of this mod.

## Mod Overview and Purpose

The "Better Scenario Research and Tech Level Options" mod provides enhanced options for selecting your game's starting research and faction tech level. It was created to offer players more flexibility and a better experience, especially when combining with the "Semi Random Research" mod.

### Purpose

This mod primarily aims to:
- Allow starting research to be completed based on the selected tech level.
- Enable a more cohesive and tailored gameplay experience for different tech tiers, from Neolithic to Archotech.
- Support smooth integration with existing scenarios without altering hidden research structures inherent to RimWorld's gameplay.

## Key Features and Systems

### Key Features

1. **Scenario Options**: Choose from six technology tiers (Neolithic to Archotech) at the start of a new game, with corresponding research projects automatically completed.
2. **Compatibility Assurance**: Designed to coexist with various scenarios and mods without conflicts in load order.
3. **Preservation of Scenario Integrity**: Maintains scenario-specific hidden research to preserve intended gameplay themes.

### Companion Mod Suggestions

- **Research Reinvented**
- **Semi Random Research**
- **Tech Advancing and Tech Traversal**
- **TechBlock**
- **Ignorance is Bliss**
- **Arcane Technology**
- **I Can't Fix That**

Each companion mod offers unique functionalities that amplify the technological progression and strategic elements of RimWorld gameplay.

## Coding Patterns and Conventions

The coding structure in this mod follows typical C# conventions, emphasizing readability and maintainability. Here are some patterns used:

- **Class Structure**: Use public classes like `GameComponent_ScenarioFactionTechLevel` and `ScenPart_SetTechLevel` to encapsulate core functionalities.
- **Method Naming**: Methods such as `SetTechLevel` are named to clearly indicate their purpose.
- **Static Utility Methods**: Utility functions are housed in a `Utility` static class for easy access across the project.

## XML Integration

XML is vital in defining and integrating mod functionalities with RimWorld. Ensure XML definitions for scenarios, research projects, and tech levels are carefully structured to align with C# logic.

- **Scenario Definitions**: Use XML to define scenario parts and tie them with C# logic.
- **Research XMLs**: Organize research projects according to tech levels specified in C# classes.

## Harmony Patching

Harmony Patching is used to integrate custom logic without modifying the base game code. This allows for flexibility and future compatibility.

- **Patch Focus**: Focus on critical points in the game's methods where tech level initialization and research setup are configured.
- **Balance**: Ensure patches maintain game balance by only affecting the intended elements and minimizing side effects.

## Suggestions for Copilot

When using GitHub Copilot for this project, consider focusing on:
- **Helper Functions**: Generate helper methods for complex logic, such as determining available research based on tech level.
- **Refactoring Code**: Use Copilot suggestions for improving code structure and efficiency.
- **Scenario Enhancements**: Automate XML updates reflecting C# changes when new scenario editing features are introduced.
- **Documentation**: Leverage Copilot to improve inline comments and documentation for better code understanding and maintenance.

These tips should help streamline development using Copilot, facilitating advanced features while maintaining a robust and efficient codebase. Feel free to experiment with suggestions and enhance the mod further!
