CAEXSequence&lt;T>.Insert Method
================================
Inserts the specified CAEX object into this sequence. If no position is specified the element is appended. If 'asFirst' is set to `true`, the element is prepended to already existing ones.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual T Insert(
	T caexObject,
	bool asFirst = true
)
```

#### Parameters

##### *caexObject*
Type: [T][2]  
the CAEX object

##### *asFirst* (Optional)
Type: [System.Boolean][3]  
 optional parameter, if set to `true (default)` the object is prepended to already existing ones, otherwise it is appended.

#### Return Value
Type: [T][2]  
 The inserted CAEX object. If the provided CAEX object already belongs to a sequence, a copy of the CAEX object is inserted and returned as the result. 

Remarks
-------
 If the provided CAEX object already has an associated parent, a deep copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[CAEXSequence&lt;T> Class][2]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png