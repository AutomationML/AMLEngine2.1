IQuery.ElementsWithIDReference Method
=====================================
Gets alls the descendant elements from the provided CAEX object, which have a reference to the provided ID. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
IEnumerable<ICAEXReference> ElementsWithIDReference(
	CAEXBasicObject caexObject,
	string ID,
	string elementName = ""
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object.

##### *ID*
Type: [System.String][3]  
The identifier.

##### *elementName* (Optional)
Type: [System.String][3]  
If parameter is set, only elements with the given element Name are considered.

#### Return Value
Type: [IEnumerable][4]&lt;[ICAEXReference][5]>  
a collection of element references which have a reference to the provided ID

See Also
--------

#### Reference
[IQuery Interface][6]  
[Aml.Engine.Services.Interfaces Namespace][1]  
[Aml.Engine.Services.Interfaces.ICAEXReference][5]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: ../ICAEXReference/README.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png