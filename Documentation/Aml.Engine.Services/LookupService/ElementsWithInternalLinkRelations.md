LookupService.ElementsWithInternalLinkRelations Method
======================================================
Returns all InternalElements and SystemUnitClasses which are descendants of the provided CAEX object, which are related to others via InternalLinks.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public IEnumerable<SystemUnitClassType> ElementsWithInternalLinkRelations(
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
#### Implements
[IQuery.ElementsWithInternalLinkRelations(CAEXBasicObject)][5]  


Exceptions
----------

Exception                  | Condition  
-------------------------- | ---------- 
[ArgumentNullException][6] | caexObject 


Remarks
-------
 Note the difference to the method [AllElementsWithInternalLinks(CAEXBasicObject)][7] which doesn't return the related elements but the InternalLink owners. 

See Also
--------

#### Reference
[LookupService Class][8]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.CAEX/SystemUnitClassType/README.md
[5]: ../../Aml.Engine.Services.Interfaces/IQuery/ElementsWithInternalLinkRelations.md
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: ../../Aml.Engine.Services.Interfaces/IQuery/AllElementsWithInternalLinks.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png