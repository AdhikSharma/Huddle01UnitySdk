# Huddle01 Unity Native Plugin

The **Huddle01 Unity Native Plugin** provides Unity developers with the ability to integrate real-time communication features, including audio and video chat, messaging, and room creation, directly into their Unity projects. This plugin is ideal for games and applications requiring communication between users.

## Features
- **Audio Chat**: High-quality audio communication for games and applications.
- **Video Chat**: Seamless video streaming with low latency.
- **Message Chat**: Real-time text messaging for users.
- **Room Creation**: Create and manage communication rooms within your app.

## Getting Started

### Installation

To use this plugin in your Unity project:

1. Download the latest version from the [Releases](https://github.com/AdhikSharma/Huddle01UnitySdk/releases) section of this GitHub repository.
2. Import the plugin into your Unity project.
3. Add the following dependencies manually in your `Packages/manifest.json`:

```json
{
  "dependencies": {
    "com.unity.nuget.newtonsoft-json": "3.2.1",
    "com.endel.nativewebsocket": "https://github.com/endel/NativeWebSocket.git#upm",
    "com.unity.webrtc": "3.0.0-pre.7"
  }
}
