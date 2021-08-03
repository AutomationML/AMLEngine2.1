QueryService.AllClassReferencesDeep Method (CAEXObject)
=======================================================
AutomationML 2.1 APIGets all classes which have references to the provided CAEX object and their referencing classes (recursive)

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<CAEXObject> AllClassReferencesDeep(
	CAEXObject caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXObject][2]  
The CAEX object.

#### Return Value
Type: [IEnumerable][3]&lt;[CAEXObject][2]>  

[Missing &lt;returns> documentation for "M:Aml.Engine.Services.QueryService.AllClassReferencesDeep(Aml.Engine.CAEX.CAEXObject)"]

#### Implements
[IQuery.AllClassReferencesDeep(CAEXObject)][4]  


See Also
--------

#### Reference
[QueryService Class][5]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: ../../Aml.Engine.Services.Interfaces/IQuery/AllClassReferencesDeep_1.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png