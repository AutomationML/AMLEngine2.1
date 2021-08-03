IQuery.ElementsWithInternalLinkRelations Method
===============================================
AutomationML 2.1 APIReturns all InternalElements and SystemUnitClasses which are descendants of the provided CAEX object, which are related to others via InternalLinks.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
IEnumerable<SystemUnitClassType> ElementsWithInternalLinkRelations(
	CAEXBasicObject caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object.

#### Return Value
Type: [IEnumerable][3]&lt;[SystemUnitClassType][4]>  
A collection of related SystemUnitClass objects

Remarks
-------
 Note the difference to the method [AllElementsWithInternalLinks(CAEXBasicObject)][5] which doesn't return the related elements but the InternalLink owners. 

See Also
--------

#### Reference
[IQuery Interface][6]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[5]: AllElementsWithInternalLinks.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png