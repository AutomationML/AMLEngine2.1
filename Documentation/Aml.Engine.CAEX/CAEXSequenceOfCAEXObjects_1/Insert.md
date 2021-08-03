CAEXSequenceOfCAEXObjects&lt;T>.Insert Method
=============================================
AutomationML 2.1 APIInserts the specified element into this sequence. If nothing is specified the element is added. If the asFirst is set to `true`, the element is prepended to already existing ones. If a UniqueNameService can be located, the name of the inserted element is changed to be unique.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override T Insert(
	T caexObject,
	bool asFirst = true
)
```

#### Parameters

##### *caexObject*
Type: [T][2]  
The CAEX object.

##### *asFirst* (Optional)
Type: [System.Boolean][3]  
 optional parameter, if set to `true (default)` the element is prepended to already existing ones, otherwise it is appended.

#### Return Value
Type: [T][2]  
 The inserted CAEX object. If the provided CAEX object already belongs to a sequence, a copy of the CAEX object is inserted and returned as the result. 

Exceptions
----------

Exception                  | Condition  
-------------------------- | ---------- 
[ArgumentNullException][4] | caexObject 


Remarks
-------
 If the provided CAEX object already has an associated parent, a deep copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[CAEXSequenceOfCAEXObjects&lt;T> Class][2]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png