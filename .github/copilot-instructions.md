# GitHub Copilot Instructions for Better Scenario Research and Tech Level Options (Continued)

## Mod Overview and Purpose
The Better Scenario Research and Tech Level Options (Continued) mod aims to enhance gameplay by providing better options for setting your game's starting research and player faction tech level. It's designed to appeal to players who prefer to skip initial Neolithic and Medieval research stages and jump directly to higher tech levels for a more seamless play experience. This mod distinguishes itself by offering the ability to start with completed research projects at specified tech levels, alongside preserving key scenario-specific gameplay elements.

## Key Features and Systems
- **Tech Tier Selection**: Offers 6 scenario options to choose your starting tech level, from Neolithic to Archotech.
- **Auto-Completion of Research**: Automatically completes all research below the selected tech tier.
- **Scenario Integrity**: Preserves hidden research specific to game scenarios, ensuring no disruption to unique gameplay elements of scenarios like Crashlanded or Rich Explorer.
- **Compatibility**: Designed to work seamlessly in your mod load order and flags potential issues to the developers for feedback.
- **Scenario Editor Integration**: Can be accessed via the Scenario Editor in-game to customize starting tech levels easily.

## Coding Patterns and Conventions
- **C# Coding Style**: 
  - Follow standard C# naming conventions with PascalCase for class names and methods.
  - Use comments judiciously to document the purpose of classes and methods.
- **Modular Code Structure**: Maintain separation of concerns by organizing classes specific to their functions, such as `GameComponent_ScenarioFactionTechLevel` for tech level settings and utility functions in a dedicated `Utility` class.

## XML Integration
- Use RimWorld's XML Defs to integrate scenario options and tech levels into the game's interface.
- Ensure XML tags are appropriately closed and nested to avoid loading errors.
- Preserve mod compatibility by referencing existing defs rather than overwriting them.

## Harmony Patching
- Implement Harmony patches where necessary to modify game behavior without altering core game files.
- Ensure patches are appropriately targeted to methods that require modification, typically using `HarmonyPatch` attributes.
- Safeguard patches against potential mod conflicts by catching exceptions and logging them for troubleshooting.

## Suggestions for Copilot
- **XML Templates**: Provide Copilot with examples of XML Defs for typical scenario options.
- **Harmony Examples**: Include samples of basic harmony patches to guide automatic completion of similar patterns.
- **C# Method Structures**: Offer Copilot templates for class and method declarations to encourage consistent coding practices.
- **Error Handling Patterns**: Reinforce best practices for error checking and exception handling.
- **Documentation and Comments**: Encourage descriptive comments that enhance readability and maintainability of the code.

---

## File Overview

### .NETFramework,Version=v4.8.AssemblyAttributes.cs
- This file contains assembly-level attributes tied to the .NET framework version used by the mod. No methods or class definitions applicable here.

### GameComponent_ScenarioFactionTechLevel.cs
- **Class**: `GameComponent_ScenarioFactionTechLevel`
  - **Method**: `SetTechLevel(TechLevel localTechLevel)`: Configures the game's starting tech level based on scenario settings.

### ScenPart_SetTechLevel.cs
- **Class**: `ScenPart_SetTechLevel`
  - No methods explicitly detailed; class is responsible for managing scenario technology level settings.

### Utility.cs
- **Class**: `Utility`
  - Acts as a helper class containing static methods for various operations related to tech levels and scenarios.

## Additional Notes
- When reporting issues, use the provided Discord channel and Log Uploader tool to ensure effective troubleshooting.
- Experiment with potential mod combinations to confirm compatibility or issues that might arise post-release.
- For best support and updates, regularly check and contribute to the dedicated GitHub repository.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.
