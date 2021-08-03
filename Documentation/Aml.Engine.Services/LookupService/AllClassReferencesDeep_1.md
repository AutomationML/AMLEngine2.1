LookupService.AllClassReferencesDeep Method (CAEXObject)
========================================================
Gets all classes which have references to the provided CAEX object and their referencing classes (recursive). This method extends the [AllClassReferences(CAEXObject)][1] and gets not only the directly derived classes of a base class but also the derived classes of these classes and further on.

  **Namespace:**  [Aml.Engine.Services][2]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public IEnumerable<CAEXObject> AllClassReferencesDeep(
	CAEXObject caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXObject][3]  
The CAEX object.

#### Return Value
Type: [IEnumerable][4]&lt;[CAEXObject][3]>  
 The derived classes tree for the specified base class. 
#### Implements
[IQuery.AllClassReferencesDeep(CAEXObject)][5]  


See Also
--------

#### Reference
[LookupService Class][6]  
[Aml.Engine.Services Namespace][2]  

[1]: ../../Aml.Engine.Services.Interfaces/IQuery/AllClassReferences_1.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: ../../Aml.Engine.Services.Interfaces/IQuery/AllClassReferencesDeep_1.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png