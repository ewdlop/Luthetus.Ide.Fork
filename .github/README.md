# GitHub Configuration

This directory contains GitHub-specific configuration files for the Luthetus.Ide repository.

## Contents

- **labels.yml** - Label definitions for issues and pull requests
- **milestones.yml** - Milestone definitions for project planning
- **LABELS.md** - Documentation for labels and milestones usage
- **workflows/** - GitHub Actions workflows
  - **main.yml** - Builds and deploys to GitHub Pages
  - **sync-labels.yml** - Automatically syncs labels to the repository

## Labels

The repository uses a comprehensive label system to organize and categorize issues and pull requests. Labels are organized into categories:

- **Type** - What kind of work (bug, feature, enhancement, etc.)
- **Priority** - How urgent (critical, high, medium, low)
- **Status** - Current state (wip, blocked, help-wanted, etc.)
- **Component** - Which part of the codebase
- **Platform** - Which platform (Linux, Windows, Mac, WASM, Photino)
- **Language** - Which language parser/compiler

See [LABELS.md](LABELS.md) for complete documentation.

## Milestones

Milestones are used to track progress toward releases and major development phases. Current milestones include:

- v1.0.0 - Initial Stable Release
- v0.10.0 through v0.13.0 - Beta releases with specific focus areas
- Backlog - Future planned work
- Community Contributions - Issues suitable for external contributors

## Automated Workflows

### Label Syncing

The `sync-labels.yml` workflow automatically applies the labels defined in `labels.yml` to the repository. This ensures consistency and makes it easy to update labels.

To sync labels manually:
1. Go to Actions tab in GitHub
2. Select "Sync Labels" workflow
3. Click "Run workflow"

### GitHub Pages Deployment

The `main.yml` workflow builds and deploys the Blazor WebAssembly application to GitHub Pages on every push to the main branch.

## Contributing

When contributing:
- Apply appropriate labels to your issues and PRs
- Refer to [LABELS.md](LABELS.md) for label usage guidelines
- See [../CONTRIBUTING.md](../CONTRIBUTING.md) for general contribution guidelines
