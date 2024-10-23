param (
	$Namespace="homerv2-local",
    $ReleaseName="homerv2-local",
    $User = ""
)

if([string]::IsNullOrEmpty($User) -eq $false)
{
    $Namespace += '-' + $User
    $ReleaseName += '-' + $User
}

helm uninstall ${ReleaseName} --namespace ${Namespace}