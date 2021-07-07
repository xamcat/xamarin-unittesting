# Xamarin Unit Testing

## Run Tests

From the root folder run the following command

```dotnetcli
dotnet test
```

Or if you want to skip building all the project just run the following command,specifying the exact unit test project to run

```dotnetcli
dotnet test XamarinUnitTesting.UnitTests/XamarinUnitTesting.UnitTests.csproj
```

In case of successful execution, your output should be the following

```dotnetcli
Test run for /Users/my_user/Sources/xamarin-unittesting/XamarinUnitTesting.UnitTests/bin/Debug/net5.0/XamarinUnitTesting.UnitTests.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.10.0-preview-20210317-02
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.

Passed!  - Failed:     0, Passed:     3, Skipped:     0, Total:     3, Duration:  - /Users/my_user/Sources/xamarin-unittesting/XamarinUnitTesting.UnitTests/bin/Debug/net5.0/XamarinUnitTesting.UnitTests.dll (net5.0)
```

## Xamarin.CommunityToolkit issue

After referencing the [Xamarin.CommunityToolkit](https://www.nuget.org/packages/Xamarin.CommunityToolkit/) package at `XamarinUnitTesting` and `XamarinUnitTesting.UnitTests` project, the unit tests are no longer compilable/executable:

> /usr/local/share/dotnet/sdk/6.0.100-preview.3.21202.5/Sdks/Microsoft.NET.Sdk/targets/Microsoft.NET.Sdk.DefaultItems.targets(362,5): error NETSDK1136: The target platform must be set to Windows (usually by including '-windows' in the TargetFramework property) when using Windows Forms or WPF, or referencing projects or packages that do so. [/Users/my_user/Sources/xamarin-unittesting/XamarinUnitTesting.UnitTests/XamarinUnitTesting.UnitTests.csproj]
