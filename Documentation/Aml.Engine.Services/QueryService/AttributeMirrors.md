QueryService.AttributeMirrors Method
====================================
AutomationML 2.1 APIReturns all Mirrors of the specified Attribute

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<AttributeType> AttributeMirrors(
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
#### Implements
[IQuery.AttributeMirrors(AttributeType)][4]  


See Also
--------

#### Reference
[QueryService Class][5]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/AttributeType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.Services.Interfaces/IQuery/AttributeMirrors.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png