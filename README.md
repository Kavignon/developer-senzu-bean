# The developper senzu-bean (DSB)

## Introduction
A dotnet CLI supporting power users searching for ways to avoid executing redundant steps in the environment regarding cleanup and setup before executing programs. 
 
## Motivations
There are always concerns on my end wherenver I start working on a specific project due to having a dirty environment and thinking about what needs to get done to cleaning and setting it up before I can debug my way through the problem that I am facing. I got tired of keeping track of different solutions and would rather have a centralized approach allowing me do everything in a single location.

## What to expect from the tool
As mentioned before, this is a CLI tool meant for power users who want to skip redundant steps and make their lives simpler. This is a composable tool allowing developers to make it their own.

There will be default programs that are downloaded, installed and updated by the tool if a developper wishes for it.

Not only that, but you can use the default automation provided by the DSB and add your own :)\

### Example of default programs
- Git,
- NuGet,
- .NET

### Development dependency configuration file
By extending the development dependency configuration file, developers will be able to force the CLI to keep track of other applications that need to care about.

### Examples of the default automation
- Pruning old branches in Git,
- Clearing the NuGet cache,
- Deleting untracked files

Developers can also for default programs to have options allowing them to merge multiple automations together as a single operation.

### Custom automation
Developers can expect to find a framework allowing them to create their own automation embedded in the DBS. For instance, if there are script files that you wish would be ran by the tool in a specific sequence and/or in parallel, you'll be able to do so. Another example, if you find yourself always running the same yarn commands, you could abstract those in the framework and create your own binding in DBS to make sure you never have to think about it.
