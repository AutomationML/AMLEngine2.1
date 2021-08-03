IQuery.IsMaster Method (InternalElementType)
============================================
AutomationML 2.1 APIDetermines whether the specified InternalElement is referenced by other InternalElement objects called 'Mirrors'.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
bool IsMaster(
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

See Also
--------

#### Reference
[IQuery Interface][4]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png