AttributeTypeType.Insert Method (Int32, CAEXWrapper)
====================================================
Inserts the specified CAEX object in it's associated sequence at the defined position. The AttributeType defines additional sequences for [Attribute][1], [Constraint][2] and [RefSemantic][3].

  **Namespace:**  [Aml.Engine.CAEX][4]  
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
Type: [System.Int32][5]  
the position

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXWrapper][6]  
The CAEX object.

#### Return Value
Type: [Boolean][7]  
`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`. 
#### Implements
[ICAEXBasicObject.Insert(Int32, CAEXWrapper)][8]  
[ICAEXBasicObject.Insert(Int32, CAEXWrapper)][8]  


Remarks
-------
 If the provided CAEX object already has an associated parent, a copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[AttributeTypeType Class][9]  
[Aml.Engine.CAEX Namespace][4]  

[1]: Attribute.md
[2]: Constraint.md
[3]: RefSemantic.md
[4]: ../README.md
[5]: https://docs.microsoft.com/dotnet/api/system.int32
[6]: ../CAEXWrapper/README.md
[7]: https://docs.microsoft.com/dotnet/api/system.boolean
[8]: ../ICAEXBasicObject/Insert_1.md
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png