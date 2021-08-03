QueryService.IsMaster Method (ExternalInterfaceType)
====================================================
AutomationML 2.1 APIDetermines whether the specified ExternalInterface is referenced by other ExternalInterface objects called 'Mirrors'.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool IsMaster(
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
#### Implements
[IQuery.IsMaster(ExternalInterfaceType)][4]  


See Also
--------

#### Reference
[QueryService Class][5]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/ExternalInterfaceType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../../Aml.Engine.Services.Interfaces/IQuery/IsMaster_1.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png