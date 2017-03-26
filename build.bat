@echo off
MsBuild.exe .\XFormsLocalizeExtension.sln /t:Build /p:Configuration=Release
.\nuget\nuget.exe pack XFormsLocalizeExtension.nuspec -ForceEnglishOutput