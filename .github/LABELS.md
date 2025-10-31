# Labels and Milestones Guide

This document describes the label system and milestones used in the Luthetus.Ide repository for organizing issues and pull requests.

## Labels

Labels are organized into several categories to help classify and filter issues effectively.

### Type Labels

These labels identify the kind of work involved:

- **type: bug** - Something isn't working correctly
- **type: enhancement** - Improvement to existing functionality
- **type: feature** - New feature or capability
- **type: documentation** - Documentation improvements or additions
- **type: refactor** - Code refactoring without changing functionality
- **type: test** - Adding or updating tests
- **type: maintenance** - Repository maintenance and infrastructure

### Priority Labels

These labels indicate urgency:

- **priority: critical** - Must be fixed immediately (security, data loss, complete breakage)
- **priority: high** - Should be addressed soon (significant impact)
- **priority: medium** - Normal priority (standard development work)
- **priority: low** - Nice to have (minor improvements)

### Status Labels

These labels track the current state of an issue or PR:

- **status: wip** - Work in progress
- **status: blocked** - Blocked by another issue or external factor
- **status: help-wanted** - Extra attention or help is needed
- **status: good-first-issue** - Good for newcomers to the project
- **status: needs-review** - Waiting for review
- **status: needs-testing** - Needs testing before completion

### Component Labels

These labels identify which part of the codebase is affected:

- **component: ide** - IDE-specific functionality
- **component: text-editor** - Text editor component
- **component: compiler-services** - Compiler services (C#, Python, JavaScript, etc.)
- **component: common** - Common library components
- **component: extensions** - Extensions (Git, DotNet, Config, Website)

### Platform Labels

These labels indicate platform-specific issues:

- **platform: linux** - Linux-specific issue
- **platform: windows** - Windows-specific issue
- **platform: mac** - macOS-specific issue
- **platform: wasm** - WebAssembly/Browser-specific issue
- **platform: photino** - Photino webview-specific issue

### Language Labels

These labels relate to language parser/compiler work:

- **lang: csharp** - C# language support
- **lang: python** - Python language support
- **lang: javascript** - JavaScript language support
- **lang: fsharp** - F# language support
- **lang: css** - CSS language support
- **lang: razor** - Razor language support

### Other Labels

- **dependencies** - Dependency updates
- **security** - Security-related issue or update
- **performance** - Performance improvements
- **accessibility** - Accessibility improvements
- **breaking-change** - Breaking change that requires major version bump
- **duplicate** - Duplicate of another issue
- **wontfix** - Will not be fixed or implemented
- **invalid** - Invalid issue or request
- **question** - Question or discussion

## Using Labels

### For Issue Authors

When creating an issue, try to apply at least:
1. One **type** label (bug, enhancement, feature, etc.)
2. One **component** label (what part of the code)
3. A **platform** label if the issue is platform-specific

### For Maintainers

Maintainers should additionally apply:
1. A **priority** label
2. **status** labels as appropriate
3. Additional labels as needed for filtering and organization

### Label Combinations

Good examples of label combinations:

- `type: bug` + `priority: high` + `component: text-editor` + `platform: windows`
- `type: feature` + `priority: medium` + `component: compiler-services` + `lang: csharp`
- `type: enhancement` + `priority: low` + `component: ide` + `status: help-wanted`
- `type: bug` + `priority: critical` + `security` + `component: common`

## Milestones

Milestones are used to group issues and PRs into releases or development phases.

### Current Milestones

- **v1.0.0 - Initial Stable Release** - First production-ready release
- **v0.10.0 - Beta Improvements** - Stability and performance focus
- **v0.11.0 - Extended Language Support** - Multi-language support expansion
- **v0.12.0 - Developer Experience** - Productivity features
- **v0.13.0 - Collaboration Features** - Team collaboration tools
- **Backlog** - Planned features not yet scheduled
- **Community Contributions** - Issues suitable for external contributors

### Using Milestones

Issues should be assigned to milestones based on:
1. When the feature/fix is planned to be released
2. The priority and dependencies
3. Available resources and timeline

Issues without a milestone are typically in triage or not yet planned for a specific release.

## Automated Label Syncing

The repository uses a GitHub Actions workflow to automatically sync labels from `.github/labels.yml` to the repository. This ensures consistency and makes it easy to update labels across the project.

The workflow runs:
- When `.github/labels.yml` is modified and pushed to main
- When manually triggered via workflow dispatch

## Contributing

When contributing to the project, please:
1. Label your issues and PRs appropriately
2. Check existing labels before creating new ones
3. Suggest new labels via issue if needed
4. Follow the labeling conventions described above

For questions about labels or milestones, please open a discussion or issue with the `question` label.
