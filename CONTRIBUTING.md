Contributing to Luthetus.Ide
============================

Labels and Milestones
---------------------
We use labels and milestones to organize issues and pull requests. Please see [.github/LABELS.md](.github/LABELS.md) for:
- A complete list of available labels and their meanings
- How to use labels effectively
- Information about project milestones
- Guidelines for contributors and maintainers

When creating issues or PRs, please apply appropriate labels to help with organization and prioritization.

Pull requests (PRs)
---------------------

- Target the 'staging' branch
- Create a draft pull request.
- Don't modify or add unrelated files.
- Apply appropriate labels to your PR (see [.github/LABELS.md](.github/LABELS.md))
- I (Hunter Freeman), plan to merge 'staging' into 'beta' every 3 weeks.
- After a week of 'beta' being stable, I will merge 'beta' into 'main'
- For clarity: I intend to publish the 'beta' branch locally to my computer, and have it be where I develop from. This adds an extra check before any code gets into 'main'.

Side notes:
- I need to build up the test suite more. This way people can be more confident in their changes not breaking something prior to a maintainer looking at it.


Applications should be tested before a maintainer merges a PR
-------------------------------------------------------------
- Luthetus.Ide.Photino.csproj
	- Linux
	- Windows
	- Mac
- Luthetus.Ide.Wasm.csproj
	- Chromium
	- Firefox
- Luthetus.Ide.ServerSide.csproj
	- Chromium
	- Firefox

Unit tests should be ran before a maintainer merges a PR
--------------------------------------------------------
- For each PR keep track of the pass/fail count after running every unit test on 'master' branch vs 'staging' branch.
