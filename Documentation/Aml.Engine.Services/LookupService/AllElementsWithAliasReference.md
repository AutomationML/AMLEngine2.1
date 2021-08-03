LookupService.AllElementsWithAliasReference Method
==================================================
Gets all the elements which are descendants of the provided CAEX object and use an alias reference. Elements referencing the same Alias are grouped together. Use this method to validate the existence of referenced externals. If the *elementName* is set, only elements with the defined element name are considered.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public ILookup<string, ICAEXReference> AllElementsWithAliasReference(
	CAEXBasicObject caexObject,
	string elementName = ""
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object.

##### *elementName* (Optional)
Type: [System.String][3]  
If parameter is set, only elements with the given element Name are considered.

#### Return Value
Type: [ILookup][4]&lt;[String][3], [ICAEXReference][5]>  
 Lookup table of elements with Alias references. The Alias part of the CAEXPath is used as a dictionary key. 
#### Implements
[IQuery.AllElementsWithAliasReference(CAEXBasicObject, String)][6]  


See Also
--------

#### Reference
[LookupService Class][7]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2
[5]: ../../Aml.Engine.Services.Interfaces/ICAEXReference/README.md
[6]: ../../Aml.Engine.Services.Interfaces/IQuery/AllElementsWithAliasReference.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png