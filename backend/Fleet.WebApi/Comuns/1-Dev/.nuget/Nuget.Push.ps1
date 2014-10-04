
.\nuget pack ..\Security\Security.csproj -Prop Configuration=Release

.\nuget push *.nupkg -s \\buildserver.vvs\Packages



