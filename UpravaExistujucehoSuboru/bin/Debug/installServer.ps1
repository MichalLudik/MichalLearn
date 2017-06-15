param(
	$serverHost = "abc",
	$serverPort = "11000",
	$keeConnectionPeriod = "1000000"
)

$servicePath = Join-Path $(Get-Location) "Server.exe";
$binPath = "$servicePath `"$serverHost $serverPort $keeConnectionPeriod`"";
$serviceName = "ADMServer";
# sc.exe delete ADMServer

if(!(Get-Service | Where-Object {$_.Name -eq $serviceName})) {
    Write-Host "Registring '$serviceName' service from '$binPath'.";
    New-Service -Name $serviceName -BinaryPathName $binPath;
}
else {
    Write-Host "Service '$serviceName' is already registered.";
}

Start-Service -Name $serviceName;