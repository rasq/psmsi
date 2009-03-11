#Requires -Version 2.0

DATA aliases {
	convertfrom-stringdata @"
Get-WIFileHash = Get-MSIFileHash
Get-WIFileType = Get-MSIFileType
Get-WIPatchInfo = Get-MSIPatchInfo
Get-WIProductInfo = Get-MSIProductInfo
Get-WIRelatedProductInfo = Get-MSIRelatedProductInfo
Get-WISource = Get-MSISource
"@
}

function Get-WISharedComponentInfo {

<#
.Synopsis
	Gets all shared components registered to the user or machine.
.Description
	Shared components are components that are installed by multiple products to the same location.
	This cmdlet will enumerate all shared components and format them in the pipeline grouped by ComponentCode.
	Because all components are being enumerated, this cmdlet may take a while to complete.
.Parameter ComponentCode
	The optional ComponentCode to enumerate specific components.
.Parameter Count
	The optional minimal number of shared components to display. This must be 2 or more.
.Example
	PS> get-wisharedcomponentinfo | format-table -view Clients
.Link
	Get-WIComponentInfo
	Group-Object
	Select-Object
	Sort-Object
	Format-Table
#>

	[CmdletBinding()]
	param (
		[Parameter(Position = 0, ValueFromPipelineByPropertyName = $true)]
		[ValidateNotNullOrEmpty()]
		[Microsoft.WindowsInstaller.PowerShell.ValidateGuid()]
		[string[]] $ComponentCode,
		
		[Parameter(Position = 1)]
		[ValidateRange(2, 2147483647)]
		[int] $Count = 2
	)
	
	end {
		$getcomponents = { get-wicomponentinfo }
		if ($ComponentCode) {
			$getcomponents = { get-wicomponentinfo -componentcode $ComponentCode }
		}
		& $getcomponents | group-object -property ComponentCode | where-object { $_.Count -ge $Count } `
			| select-object -expand Group | sort-object -property ComponentCode, ProductCode
	}
}

$aliases.GetEnumerator() | foreach-object -process {
	new-alias -name $_.name -value $_.value -scope "global" -option ReadOnly -force
}
export-modulemember -alias $aliases.Keys -function "Get-WISharedComponentInfo"
