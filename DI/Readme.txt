First Add empty MVc project
Install Ninject.Mvc5 from Nuget 
In 3.2.1 version NInjectWebCommon.cs file automatically added but in 3.3.0(New Version) we have to add code .Code can get from 
GitHub. https://github.com/SkydivingAngel/Ninject-WebApi-2-and-Mvc5
Configure Your Dependency Injection in Register Congfigure service Ninject.
After that add interface as IMyInterface and implement interface in MyConcreteClass.
After that Add MvcTestController there we have to pass our repository as interface variable in contructor as parameter.

Note:- This project is most of using ready made classes but yeah DI Flow is there.