LookupService.AllClassReferences Method (CAEXObject)
====================================================
AutomationML 2.1 APIGets all classes which have references to the provided CAEX object. Use this method to get all classes which have a class to class relation to the provided CAEX object.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public IEnumerable<CAEXObject> AllClassReferences(
	CAEXObject caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXObject][2]  
The CAEX object.

#### Return Value
Type: [IEnumerable][3]&lt;[CAEXObject][2]>  
 An enumeration of all classes which use the provided CAEX object as a base class. 
#### Implements
[IQuery.AllClassReferences(CAEXObject)][4]  


See Also
--------

#### Reference
[LookupService Class][5]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.Services.Interfaces/IQuery/AllClassReferences_1.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png