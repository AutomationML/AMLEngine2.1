LookupService.ElementsWithCAEXPathReference Method
==================================================
AutomationML 2.1 APIGets alls the elements which are descendants of the provided CAEX object which have a reference to the provided CAEXPath. The elements in the result collection are references, which define the CAEX object and the attribute, containing the reference . If the *elementName* is set, only elements with the defined element name are considered.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public IEnumerable<ICAEXReference> ElementsWithCAEXPathReference(
	CAEXBasicObject caexObject,
	string caexPath,
	string elementName = ""
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object.

##### *caexPath*
Type: [System.String][3]  
The path.

##### *elementName* (Optional)
Type: [System.String][3]  
If parameter is set, only elements with the given element Name are considered.

#### Return Value
Type: [IEnumerable][4]&lt;[ICAEXReference][5]>  
 a collection of element references which have a reference to the provided Path^. 
#### Implements
[IQuery.ElementsWithCAEXPathReference(CAEXBasicObject, String, String)][6]  


See Also
--------

#### Reference
[LookupService Class][7]  
[Aml.Engine.Services Namespace][1]  
[Aml.Engine.Services.Interfaces.ICAEXReference][5]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: ../../Aml.Engine.Services.Interfaces/ICAEXReference/README.md
[6]: ../../Aml.Engine.Services.Interfaces/IQuery/ElementsWithCAEXPathReference.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png