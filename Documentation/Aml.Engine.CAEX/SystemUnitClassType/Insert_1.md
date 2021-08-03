SystemUnitClassType.Insert Method (Int32, CAEXWrapper)
======================================================
AutomationML 2.1 APIInserts the specified CAEX object in it's associated sequence. The SystemUnitClass defines the [Attribute][1], [ExternalInterface][2], [InternalElement][3], [InternalLink][4], and [SupportedRoleClass][5] sequence.

  **Namespace:**  [Aml.Engine.CAEX][6]  
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
Type: [System.Int32][7]  


##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXWrapper][8]  
The CAEX object.

#### Return Value
Type: [Boolean][9]  
`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`. 
#### Implements
[ICAEXBasicObject.Insert(Int32, CAEXWrapper)][10]  
[ICAEXBasicObject.Insert(Int32, CAEXWrapper)][10]  


Remarks
-------
 If the provided CAEX object already has an associated parent, a copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[SystemUnitClassType Class][11]  
[Aml.Engine.CAEX Namespace][6]  

[1]: Attribute.md
[2]: ExternalInterface.md
[3]: InternalElement.md
[4]: InternalLink.md
[5]: SupportedRoleClass.md
[6]: ../README.md
[7]: https://docs.microsoft.com/dotnet/api/system.int32
[8]: ../CAEXWrapper/README.md
[9]: https://docs.microsoft.com/dotnet/api/system.boolean
[10]: ../ICAEXBasicObject/Insert_1.md
[11]: README.md
[12]: https://www.automationml.org
[13]: ../../icons/logoShade.png