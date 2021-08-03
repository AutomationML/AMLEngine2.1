IQuery.AllClassReferencesDeep Method (CAEXObject)
=================================================
AutomationML 2.1 APIGets all classes which have references to the provided CAEX object and their referencing classes (recursive). This method extends the [AllClassReferences(CAEXObject)][1] and gets not only the directly derived classes of a base class but also the derived classes of these classes and further on.

  **Namespace:**  [Aml.Engine.Services.Interfaces][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
IEnumerable<CAEXObject> AllClassReferencesDeep(
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

See Also
--------

#### Reference
[IQuery Interface][5]  
[Aml.Engine.Services.Interfaces Namespace][2]  

[1]: AllClassReferences_1.md
[2]: ../README.md
[3]: ../../Aml.Engine.CAEX/CAEXObject/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png