ServiceLocator.QueryService Property
====================================
Gets the registered Query-Service. If no Query-Service is registered, a default Query-Service - which is based on LinqToXml - is returned. As an alternative, a Query-Service based on Dictionaries for keyed access is available. The dictionary based service has to be registered to be used. If no such service has been registered, the default query service is returned. The actual registered Query-Service is located by the engine and used for all queries.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IQuery QueryService { get; }
```

#### Property Value
Type: [IQuery][2]

See Also
--------

#### Reference
[ServiceLocator Class][3]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.Services.Interfaces/IQuery/README.md
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png