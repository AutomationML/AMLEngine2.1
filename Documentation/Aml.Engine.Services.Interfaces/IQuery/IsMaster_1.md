IQuery.IsMaster Method (ExternalInterfaceType)
==============================================
Determines whether the specified ExternalInterface is referenced by other ExternalInterface objects called 'Mirrors'.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
bool IsMaster(
	ExternalInterfaceType element
)
```

#### Parameters

##### *element*
Type: [Aml.Engine.CAEX.ExternalInterfaceType][2]  
The element.

#### Return Value
Type: [Boolean][3]  
`true` if the specified element is a 'Master'-ExternalInterface; otherwise, `false`. 

See Also
--------

#### Reference
[IQuery Interface][4]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png