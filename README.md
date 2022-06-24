# CleanArch
Clean Arch With Core 6 By Reza okhravi

add or update migration 
```c#
CleanArch\Persistence\CleanArch.Data> dotnet ef --startup-project ../../Presentation/CleanArch.Mvc  migrations add user
```

udapte datebase
```c#
CleanArch\Persistence\CleanArch.Data> dotnet ef database update --startup-project ../../Presentation/CleanArch.Mvc
```