ServiceLocator.UniqueNameService Property
=========================================
Gets the registered UniqueName-Service.The actual registered UniqueName-Service is located by the engine to automatically assign unique names to CAEXObjects if they are inserted into a sequence. If no UniqueName-Service is registered no names are generated.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static IUniqueName UniqueNameService { get; }
```

#### Property Value
Type: [IUniqueName][2]

See Also
--------

#### Reference
[ServiceLocator Class][3]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.Services.Interfaces/IUniqueName/README.md
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png