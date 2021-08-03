InternalElementType.Insert Method (Int32, CAEXWrapper)
======================================================
Inserts the specified CAEX object in it's associated sequence at the given position. The InternalElement defines the [RoleRequirements][1] sequence.

  **Namespace:**  [Aml.Engine.CAEX][2]  
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
Type: [System.Int32][3]  
The position.

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXWrapper][4]  
The CAEX object.

#### Return Value
Type: [Boolean][5]  
`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`. 
#### Implements
[ICAEXBasicObject.Insert(Int32, CAEXWrapper)][6]  
[ICAEXBasicObject.Insert(Int32, CAEXWrapper)][6]  
[ICAEXBasicObject.Insert(Int32, CAEXWrapper)][6]  


Remarks
-------
 If the provided CAEX object already has an associated parent, a copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[InternalElementType Class][7]  
[Aml.Engine.CAEX Namespace][2]  

[1]: RoleRequirements.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.int32
[4]: ../CAEXWrapper/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: ../ICAEXBasicObject/Insert_1.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png