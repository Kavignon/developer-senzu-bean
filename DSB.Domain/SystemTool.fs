namespace DSB.Domain

open System

module DefaultProgram =
    
    type AbsolutePath = AbsolutePath of string

    type SemanticVersion = SemanticVersion of string

    type DownloadLocation = DownloadLocation of Uri

    type OperatingSystem =
        | Linux
        | Mac
        | Windows

    type SourceCodeInstaller =
        | X64
        | Arm64
        | X86

    type WindowsBinaryInstaller =
        | Arm64
        | X64
        | X86

    type MacBinaryInstaller =
        | X64

    type LinuxBinaryInstaller =
        | Arm32
        | Arm32Alpine
        | Arm64
        | Arm64Alpine
        | X64
        | X64Alpine

    type BinaryInstaller =
        | Linux of LinuxBinaryInstaller
        | Mac of MacBinaryInstaller
        | Windows of WindowsBinaryInstaller

    type InstallationMode =
        | Installer of SourceCodeInstaller
        | Binaries of BinaryInstaller
        | Script of string

    type ToolSystemInformation = {
        SystemPath: AbsolutePath option
        CurrentVersion: SemanticVersion
    }

    type InstallerInformation = {
        Url: DownloadLocation
        OperatingSystem: OperatingSystem
        SelectedInstallationMode: InstallationMode
    }

    type SystemTool = {
        Title: string
        ToolSummary: string option
        DownloadLocation: DownloadLocation
        SystemInformation: ToolSystemInformation
        Installer: InstallerInformation
        IsEnvironmentVariable: bool
    }

module DevelopmentMachine =
    open DefaultProgram

    type Environment = {
        OS: OperatingSystem
        DefaultTools: SystemTool list option
    }