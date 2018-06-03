# Module manifest for module 'screenscrape'
# Generated by: Michael Pullen
# Generated on: 6/3/2018
#

@{

ModuleVersion = '1.0.0.0'
GUID = '831c4d9e-d90f-4e9e-8fee-46fd4d1b67d8'
Author = 'Michael Pullen'
CompanyName = 'NA'
Copyright = '(c) 2018 Michael Pullen. All rights reserved.'
Description = 'A powershell module for screen scraping html pages using HtmlAgilityPack and Fizzler'
DotNetFrameworkVersion = '4.5'
NestedModules = "ScreenScrape.dll"
FunctionsToExport = "*"
CmdletsToExport = @("New-HtmlDocument","Get-Elements","Get-Element","Get-Parent")
VariablesToExport = '*'
AliasesToExport = @()


# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        # Tags = @()

        # A URL to the license for this module.
        # LicenseUri = ''

        # A URL to the main website for this project.
        # ProjectUri = ''

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        # ReleaseNotes = ''

    } # End of PSData hashtable

} # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

