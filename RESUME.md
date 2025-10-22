# Luthetus.Ide - Project Résumé

## Overview
Luthetus.Ide is a free and open-source Integrated Development Environment (IDE) built with modern .NET technologies. It runs cross-platform on Linux, Windows, and macOS.

## Technology Stack
- **Language**: C#
- **UI Framework**: Blazor
- **Webview**: Photino (lightweight)
- **.NET Environment**: Cross-platform .NET

## Key Features
- **Multi-Language Support**: Extensible architecture supporting any programming language through the `ICompilerService` interface
- **Custom Parser & Binder**: Built-in C# parser and binder for code analysis
- **Syntax Highlighting**: Configurable decoration system for code presentation
- **Text Editor**: Full-featured text editing capabilities with keymaps (including Vim support)
- **Solution Explorer**: Project and file management
- **Integrated Terminal**: Built-in terminal support
- **Test Explorer**: Unit test discovery and execution
- **Git Integration**: Source control features
- **Extensible Panels**: Dockable panel system for tools and editors

## Architecture Highlights
The IDE is built on a modular architecture with three main libraries:

1. **Luthetus.Common**: Core UI components (dialogs, menus, notifications, tree views, etc.)
2. **Luthetus.TextEditor**: Text editing engine with syntax highlighting and language services
3. **Luthetus.CompilerServices**: Language parsing, binding, and compiler service interfaces

## Compiler Services
The IDE's language support is built around well-defined interfaces:
- `IParser`: Token-level code parsing
- `IBinder`: Semantic analysis and symbol resolution
- `ICompilerService`: Language-specific compilation services
- `ICompilerServiceRegistry`: File extension to language service mapping
- `IDecorationMapper`: Syntax highlighting and theming

## Current Status
In active development - see [README.md](./README.md) for the latest information and demos.

## Demo
Try the live demo at: https://luthetus.github.io/Luthetus.Ide/

## Documentation
- [Installation Guide](./INSTALLATION.md)
- [Contributing Guidelines](./CONTRIBUTING.md)
- [Luthetus.Common Documentation](./Docs/Common/README.md)
- [Luthetus.TextEditor Documentation](./Docs/TextEditor/README.md)
- [Luthetus.CompilerServices Documentation](./Docs/CompilerServices/README.md)

## License
This project is licensed under the terms specified in [LICENSE](./LICENSE).
