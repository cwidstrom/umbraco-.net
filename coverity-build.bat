@pushd %~dp0
@PATH=C:\Windows\Microsoft.NET\Framework\v4.0.30319;%PATH%
chmod -x .nuget/Nuget.exe
chmod 774 .nuget/Nuget.exe
MSBuild.exe ./umbraco.sln /t:build
MSBuild.exe ./Umbraco.Web.UI/Umbraco.Web.UI.csproj /t:WebPublish /p:Configuration=Debug /p:VisualStudioVersion=12.0 /p:WebPublishMethod=FileSystem /p:publishUrl=../pub
ASPNET_Compiler.exe -p pub/ -v pub/ -d -c aspnet_compiled
@popd
