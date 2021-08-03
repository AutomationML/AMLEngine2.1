IQuery.IsMaster Method (AttributeType)
======================================
AutomationML 2.1 APIDetermines whether the specified AttributeType is referenced by other AttributeType objects called 'Mirrors'.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
bool IsMaster(
	AttributeType attribute
)
```

#### Parameters

##### *attribute*
Type: [Aml.Engine.CAEX.AttributeType][2]  
The attribute type

#### Return Value
Type: [Boolean][3]  
`true` if the specified element is a 'Master'-Attribute; otherwise, `false`. 

See Also
--------

#### Reference
[IQuery Interface][4]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/AttributeType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png