LookupService.IsMaster Method (AttributeType)
=============================================
Determines whether the specified AttributeType is referenced by other AttributeType objects called 'Mirrors'.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public bool IsMaster(
	AttributeType element
)
```

#### Parameters

##### *element*
Type: [Aml.Engine.CAEX.AttributeType][2]  
The element.

#### Return Value
Type: [Boolean][3]  
`true` if the specified element is a 'Master'-Attribute; otherwise, `false`. 
#### Implements
[IQuery.IsMaster(AttributeType)][4]  


See Also
--------

#### Reference
[LookupService Class][5]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/AttributeType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../../Aml.Engine.Services.Interfaces/IQuery/IsMaster.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png