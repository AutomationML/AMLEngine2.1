IQuery.AttributeMirrors Method
==============================
AutomationML 2.1 APIReturns all Mirrors of the specified Attribute

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
IEnumerable<AttributeType> AttributeMirrors(
	AttributeType master
)
```

#### Parameters

##### *master*
Type: [Aml.Engine.CAEX.AttributeType][2]  
The master.

#### Return Value
Type: [IEnumerable][3]&lt;[AttributeType][2]>  
 An enumeration of mirror Attribute objects 

See Also
--------

#### Reference
[IQuery Interface][4]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/AttributeType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png