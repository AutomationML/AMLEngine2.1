LookupService.AllElementsWithNameReference Method
=================================================
Gets all the elements which are descendants of the provided CAEX object and use a name reference. Elements referencing the same name are grouped together. Use this method to validate the existence of referenced elements.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public ILookup<string, ICAEXReference> AllElementsWithNameReference(
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

[Missing &lt;param name="elementName"/> documentation for "M:Aml.Engine.Services.LookupService.AllElementsWithNameReference(Aml.Engine.CAEX.CAEXBasicObject,System.String)"]


#### Return Value
Type: [ILookup][4]&lt;[String][3], [ICAEXReference][5]>  
 Lookup table of elements with name references. The name is used as a grouping key. 
#### Implements
[IQuery.AllElementsWithNameReference(CAEXBasicObject, String)][6]  


Exceptions
----------

Exception                  | Condition  
-------------------------- | ---------- 
[ArgumentNullException][7] | caexObject 


See Also
--------

#### Reference
[LookupService Class][8]  
[Aml.Engine.Services Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXBasicObject/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2
[5]: ../../Aml.Engine.Services.Interfaces/ICAEXReference/README.md
[6]: ../../Aml.Engine.Services.Interfaces/IQuery/AllElementsWithNameReference.md
[7]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png