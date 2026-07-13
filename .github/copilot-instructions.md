# GitHub Copilot Instructions

## Mod Overview and Purpose
The **Better Scenario Research and Tech Level Options (Continued)** mod offers enhanced control over starting research and tech levels for players in RimWorld. Originally updated from large moron's mod, this project primarily serves users who want a more tailored, scenario-based research experience, particularly when paired with mods like Semi Random Research. It enables players to omit lower-tier technologies from their game, allowing a more direct advancement to their desired era, such as Industrial or Ultratech.

## Key Features and Systems
- **Tech Level Customization:** Provides six scenario options to start at any desired tech tier, from Neolithic to Archotech. This includes automatically completing all research below the chosen tier.
- **Archotech Tier Compatibility:** Designed to interact with mods having Archotech-tier research projects like More Archotech Garbage and Science Never Stops.
- **Scenario Integrity Protection:** Ensures certain hidden research projects remain as per the original scenario settings, protecting theme and gameplay balance.
- **Flexible Load Order:** The mod's functionality remains constant regardless of its position in the load order. Users are encouraged to report any unforeseen conflicts.

## Coding Patterns and Conventions
- The C# code is organized into three primary files, each serving a purpose in defining tech level interactions and utility functions.
  - `ScenPart_SetTechLevel.cs` handles interface edits and game start processes for tech levels.
  - `Utility.cs` offers supporting functions and structures like `EraseChanges` and `FactionTechDict`.
  - `GameComponent_ScenarioFactionTechLevel.cs` manages game components associated with tech levels, including load and save functionality.
- Standard naming conventions are followed for class and method definitions, ensuring clarity and consistency.

## XML Integration
- XML files play a crucial role in defining scenario parts (`ScenParts_Various.xml`) and mod metadata (`About.xml`, `LoadFolders.xml`).
- Use XML to specify scenario definitions and game integration elements that communicate with the C# backend.

## Harmony Patching
- Although not explicitly mentioned in the summarized content, it's advisable to consider potential Harmony patches for compatibility with other mods or base game alterations.
- If applicable, use Harmony to patch methods influencing tech level and research completion, ensuring non-intrusive and conflict-free adjustments.

## Suggestions for Copilot
- **Code Completion:** Suggest relevant defaults for tech level settings and scenario-part additions based on typical RimWorld conventions.
- **XML Tag Assistance:** Aid in the completion of XML tags for scenario definitions and load ordering.
- **Harmony Recommendations:** Propose patch entries for methods interacting with game starts and research modifications, particularly if user submissions indicate conflicts.
- **Error Tracing Enhancement:** Offer snippets for logging and exception handling in scenarios where tech level mismatches or scenario disruptions occur.

By adhering to these guidelines, contributors and automated tooling can ensure consistent quality and functionality within the **Better Scenario Research and Tech Level Options (Continued)** mod, enhancing the player's ability to customize their technological journey within RimWorld.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).

