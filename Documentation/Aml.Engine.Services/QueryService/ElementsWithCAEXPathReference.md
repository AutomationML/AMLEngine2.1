QueryService.ElementsWithCAEXPathReference Method
=================================================
AutomationML 2.1 APIGets alls the elements which are descendants of the provided CAEX object which have a reference to the provided CAEXPath.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

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
 a collection of elements which have a reference to the provided Path 
#### Implements
[IQuery.ElementsWithCAEXPathReference(CAEXBasicObject, String, String)][6]  


See Also
--------

#### Reference
[QueryService Class][7]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1
[5]: ../../Aml.Engine.Services.Interfaces/ICAEXReference/README.md
[6]: ../../Aml.Engine.Services.Interfaces/IQuery/ElementsWithCAEXPathReference.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png