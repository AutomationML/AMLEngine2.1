AttributeFamilyType.Insert Method (Int32, CAEXWrapper)
======================================================
Inserts the specified CAEX object in it's associated sequence at the given index.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override bool Insert(
	int pos,
	CAEXWrapper caexObject
)
```

#### Parameters

##### *pos*
Type: [System.Int32][2]  


##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXWrapper][3]  
The CAEX object.

#### Return Value
Type: [Boolean][4]  
`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`. 
#### Implements
[ICAEXBasicObject.Insert(Int32, CAEXWrapper)][5]  
[ICAEXBasicObject.Insert(Int32, CAEXWrapper)][5]  
[ICAEXBasicObject.Insert(Int32, CAEXWrapper)][5]  


Remarks
-------
 If the provided CAEX object already has an associated parent, a copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[AttributeFamilyType Class][6]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.int32
[3]: ../CAEXWrapper/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: ../ICAEXBasicObject/Insert_1.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png