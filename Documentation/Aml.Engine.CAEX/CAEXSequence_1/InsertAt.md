CAEXSequence&lt;T>.InsertAt Method
==================================
Inserts the specified CAEX object into this sequence at the defined index.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public T InsertAt(
	int index,
	T caexObject
)
```

#### Parameters

##### *index*
Type: [System.Int32][2]  
The Position of the element

##### *caexObject*
Type: [T][3]  
The CAEX object

#### Return Value
Type: [T][3]  
 The inserted CAEX object. If the provided CAEX object already belongs to a sequence, a copy of the CAEX object is inserted and returned as the result. 

Remarks
-------
 If the provided CAEX object already has an associated parent, a deep copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[CAEXSequence&lt;T> Class][3]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.int32
[3]: README.md
[4]: https://www.automationml.org
[5]: ../../icons/logoShade.png