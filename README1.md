# MauiProjectBWeatherA

## Visual Studio Code Debug Configuration Notes

The `.vscode/launch.json` file includes separate launch configurations for both Windows platforms:

- **".NET MAUI - win-arm64"** - For ARM64 Windows systems
- **".NET MAUI - win-x64"** - For x64 Windows systems

Select the appropriate configuration from the debug dropdown based on your system architecture.

## Targeting Mac and iOS Devices

To build and debug for Mac or iOS devices, you need to modify the `TargetFrameworks` property in `MauiProjectBWeatherA.csproj`.

### Current Configuration
The project currently targets Windows only:
```xml
<TargetFrameworks Condition="$([MSBuild]::IsOSPlatform('windows'))">$(TargetFrameworks);net9.0-windows10.0.19041.0</TargetFrameworks>
```

### Available Target Options

**For macOS and iOS only:**
```xml
<TargetFrameworks>net9.0-ios;net9.0-maccatalyst</TargetFrameworks>
```

**For Android, iOS, and macOS:**
```xml
<TargetFrameworks>net9.0-android;net9.0-ios;net9.0-maccatalyst</TargetFrameworks>
```

**For all platforms (cross-platform):**
```xml
<TargetFrameworks>net9.0-android;net9.0-ios;net9.0-maccatalyst</TargetFrameworks>
<TargetFrameworks Condition="$([MSBuild]::IsOSPlatform('windows'))">$(TargetFrameworks);net9.0-windows10.0.19041.0</TargetFrameworks>
```

### Steps to Change Target
1. Open `MauiProjectBWeatherA/MauiProjectBWeatherA.csproj`
2. Locate the `<TargetFrameworks>` element (around line 5)
3. Comment out the current target and uncomment your desired target from the available options
4. Save the file and rebuild the project

**Note:** Building for iOS and macOS requires a Mac with Xcode 26.0.1 installed. On Windows, you'll need to connect to a Mac build agent.
