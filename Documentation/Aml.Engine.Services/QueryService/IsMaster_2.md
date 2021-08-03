QueryService.IsMaster Method (InternalElementType)
==================================================
Determines whether the specified InternalElement is referenced by other InternalElement objects called 'Mirrors'.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public bool IsMaster(
	InternalElementType element
)
```

#### Parameters

##### *element*
Type: [Aml.Engine.CAEX.InternalElementType][2]  
The element.

#### Return Value
Type: [Boolean][3]  
`true` if the specified element is a 'Master'-InternalElement; otherwise, `false`. 
#### Implements
[IQuery.IsMaster(InternalElementType)][4]  


See Also
--------

#### Reference
[QueryService Class][5]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../../Aml.Engine.Services.Interfaces/IQuery/IsMaster_2.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png