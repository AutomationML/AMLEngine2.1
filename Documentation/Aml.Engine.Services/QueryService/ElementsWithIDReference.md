QueryService.ElementsWithIDReference Method
===========================================
Gets alls the elements from the document which have a reference to the provided ID. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public IEnumerable<ICAEXReference> ElementsWithIDReference(
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
#### Implements
[IQuery.ElementsWithIDReference(CAEXBasicObject, String, String)][6]  


See Also
--------

#### Reference
[QueryService Class][7]  
[Aml.Engine.Services Namespace][1]  
[Aml.Engine.Services.Interfaces.ICAEXReference][5]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: ../../Aml.Engine.Services.Interfaces/ICAEXReference/README.md
[6]: ../../Aml.Engine.Services.Interfaces/IQuery/ElementsWithIDReference.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png