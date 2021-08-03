LookupService.AllElementsIdentifiedByCAEXPath Method
====================================================
Gets all the elements which are descendants of the provided CAEX object and are identifiable by a CAEX path. Elements having the same path are grouped together. Use this method to validate the existence of ambiguous CAEXPaths.

  **Namespace:**  [Aml.Engine.Services][1]  
  **Assembly:**  AML.Engine.Services (in AML.Engine.Services.dll)

Syntax
------

```csharp
public ILookup<string, ICAEXReference> AllElementsIdentifiedByCAEXPath(
	CAEXBasicObject caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXBasicObject][2]  
The CAEX object.

#### Return Value
Type: [ILookup][3]&lt;[String][4], [ICAEXReference][5]>  
 Lookup table of elements which are identifiable by a CAEX path. 
#### Implements
[IQuery.AllElementsIdentifiedByCAEXPath(CAEXBasicObject)][6]  


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
[3]: https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: ../../Aml.Engine.Services.Interfaces/ICAEXReference/README.md
[6]: ../../Aml.Engine.Services.Interfaces/IQuery/AllElementsIdentifiedByCAEXPath.md
[7]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png