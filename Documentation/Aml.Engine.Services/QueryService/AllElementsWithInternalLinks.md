QueryService.AllElementsWithInternalLinks Method
================================================
AutomationML 2.1 APIReturns all Elements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects. The returned collection may contain InternalElements and SystemUnitClasses as well.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<SystemUnitClassType> AllElementsWithInternalLinks(
	CAEXBasicObject caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object

#### Return Value
Type: [IEnumerable][3]&lt;[SystemUnitClassType][4]>  
 A collection of all objects with associated InternalLinks. 
#### Implements
[IQuery.AllElementsWithInternalLinks(CAEXBasicObject)][5]  


Remarks
-------
 Note the difference to the method [ElementsWithInternalLinkRelations(CAEXBasicObject)][6] which doesn't return the owners of an InternalLink but the related elements. 

See Also
--------

#### Reference
[QueryService Class][7]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[5]: ../../Aml.Engine.Services.Interfaces/IQuery/AllElementsWithInternalLinks.md
[6]: ElementsWithInternalLinkRelations.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png