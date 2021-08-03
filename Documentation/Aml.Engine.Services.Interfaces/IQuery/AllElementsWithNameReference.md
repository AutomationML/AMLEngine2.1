IQuery.AllElementsWithNameReference Method
==========================================
Gets all the elements which are descendants of the provided CAEX object and use a name reference. Elements referencing the same name are grouped together. Use this method to validate the existence of referenced elements.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
ILookup<string, ICAEXReference> AllElementsWithNameReference(
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


#### Return Value
Type: [ILookup][4]&lt;[String][3], [ICAEXReference][5]>  
Lookup table of elements with name references. The name is used as a grouping key.

See Also
--------

#### Reference
[IQuery Interface][6]  
[Aml.Engine.Services.Interfaces Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2
[5]: ../ICAEXReference/README.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png