## GitHub Copilot Instructions for RimWorld Mod: Better Scenario Research and Tech Level Options (Continued)

### Mod Overview and Purpose
The "Better Scenario Research and Tech Level Options" mod enhances RimWorld's scenario options by providing better control over starting research and player faction tech levels. This mod allows players to select the technology tier at which they begin their game, ensuring a customizable and streamlined research experience. It is particularly complementary when used with the "Semi Random Research" mod, allowing players to bypass undesired early era research when starting at higher tech levels.

### Key Features and Systems
- **Flexible Starting Tech Levels:** Choose from six scenario options to start your game at any technological tier, from Neolithic to Archotech. Tiers automatically include completed research projects up to the selected level.
- **Archotech Start:** Begin with all research projects completed, including those from compatible mods like "More Archotech Garbage" for an instant dive into high-tech gameplay.
- **Scenario Integrity:** Preserves scenario-specific hidden research, maintaining designed gameplay experiences. For example, starting with electricity in scenarios that traditionally include it.
- **Mod Compatibility:** The mod is designed to fit anywhere in your load order without causing conflicts. Compatibility reports are welcomed for continuous improvement.

### Coding Patterns and Conventions
- **C# Patterns:** 
  - All key classes use standard naming conventions with PascalCase for types and methods.
  - Emphasis on modular design; classes are used to encapsulate different features such as tech level management and interface interaction.
- **Common Class Functions:**
  - Methods like `DoEditInterface()` are used for handling UI interactions.
  - Serialization or data exposure is managed through methods like `ExposeData()`.

### XML Integration
- XML files define scenario parts, mod metadata, and load order configurations.
- **ScenPartDef:** Used to specify the elements of scenario customization, facilitating the selection of different tech levels.

### Harmony Patching
- The mod may require harmony patches to ensure compatibility with other mods or to override original game functions where necessary.
- It is recommended to test thoroughly and apply patches conservatively to maintain stability.

### Suggestions for Copilot
- **For C# Development:**
  - Use Copilot to generate boilerplate code for new scenario parts or extensions of existing functionalities.
  - Leverage Copilot for exploring potential harmony patches, especially with frequently occurring hooks into game logic.
- **For XML Definitions:**
  - Enjoy automated suggestions for XML tags and attributes when defining new scenario parts, making setup more efficient.
  
### Troubleshooting and Support
- **Error Isolation:** If you encounter errors, isolate the issue by enabling only this mod and its dependencies. Gradually reintroduce other mods to identify conflicts.
- **Log Uploading:** Use the Log Uploader tool to share accurate error logs for support.
- **Community Support:** Direct error reports and solutions to the GitHub repository or designated Discord channels for assistance. Avoid GitHub discussion threads for reporting, as they may not prompt timely notifications.
- **Mod Sorting:** Utilize tools like RimSort to maintain optimal load order for maximum compatibility. 

By following these guidelines and making use of GitHub Copilot's capabilities, you can optimize development efforts for the "Better Scenario Research and Tech Level Options" mod and enhance player experience in RimWorld.

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
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

