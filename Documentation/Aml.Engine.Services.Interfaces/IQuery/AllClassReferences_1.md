IQuery.AllClassReferences Method (CAEXObject)
=============================================
Gets all classes which have references to the provided CAEX object. Use this method to get all classes which have a class to class relation to the provided CAEX object.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
IEnumerable<CAEXObject> AllClassReferences(
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

See Also
--------

#### Reference
[IQuery Interface][4]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png