IQuery.ExternalInterfaceMirrors Method
======================================
Returns all Mirrors of the specified ExternalInterface

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
IEnumerable<ExternalInterfaceType> ExternalInterfaceMirrors(
	ExternalInterfaceType master
)
```

#### Parameters

##### *master*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][2]  
The master.

#### Return Value
Type: [IEnumerable][3]&lt;[ExternalInterfaceType][2]>  
 An enumeration of mirror ExternalInterface objects 

See Also
--------

#### Reference
[IQuery Interface][4]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png