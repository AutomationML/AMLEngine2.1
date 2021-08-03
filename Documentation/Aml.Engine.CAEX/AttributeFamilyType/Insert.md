AttributeFamilyType.Insert Method (CAEXWrapper, Boolean)
========================================================
AutomationML 2.1 APIInserts the specified CAEX object in it's associated sequence.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override bool Insert(
	CAEXWrapper caexObject,
	bool asFirst = true
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXWrapper][2]  
The CAEX object.

##### *asFirst* (Optional)
Type: [System.Boolean][3]  
 if set to `true` it is inserted as the first item in its associated sequence.

#### Return Value
Type: [Boolean][3]  
`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`. 
#### Implements
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][4]  
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][4]  
[ICAEXContainer.Insert(CAEXWrapper, Boolean)][5]  
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][4]  


Remarks
-------
 If the provided CAEX object already has an associated parent, a copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[AttributeFamilyType Class][6]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: ../CAEXWrapper/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../ICAEXBasicObject/Insert.md
[5]: ../ICAEXContainer/Insert.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png