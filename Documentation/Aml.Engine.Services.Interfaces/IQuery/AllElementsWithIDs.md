IQuery.AllElementsWithIDs Method
================================
AutomationML 2.1 APIGets all the elements which are descendants of the provided CAEX object with IDs. Elements using the same ID are grouped together. Use this method to validate the uniqueness of IDs.

  **Namespace:**  [Aml.Engine.Services.Interfaces][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
ILookup<string, ICAEXReference> AllElementsWithIDs(
	CAEXBasicObject caexObject,
	string ID = ""
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object.

##### *ID* (Optional)
Type: [System.String][3]  
If an ID is specified, only elements with the defined ID are searched.

#### Return Value
Type: [ILookup][4]&lt;[String][3], [ICAEXReference][5]>  
 Lookup table of elements with IDs. The ID is used as a dictionary key. 

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