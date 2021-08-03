QueryService.AllInternalElementsWithInternalLinks Method
========================================================
Returns all InternalElements which are descendants of the provided CAEX object with InternalLinks. These elements are the owners of the InternalLink objects.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<InternalElementType> AllInternalElementsWithInternalLinks(
	CAEXBasicObject caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object.

#### Return Value
Type: [IEnumerable][3]&lt;[InternalElementType][4]>  
 A collection of all objects with associated InternalLinks. 
#### Implements
[IQuery.AllInternalElementsWithInternalLinks(CAEXBasicObject)][5]  


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
[4]: ../../Aml.Engine.CAEX/InternalElementType/README.md
[5]: ../../Aml.Engine.Services.Interfaces/IQuery/AllInternalElementsWithInternalLinks.md
[6]: ElementsWithInternalLinkRelations.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png