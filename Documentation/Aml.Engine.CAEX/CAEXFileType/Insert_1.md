CAEXFileType.Insert Method (Int32, CAEXWrapper)
===============================================
AutomationML 2.1 APIInserts the specified CAEX object in it's associated sequence at the given position. The CAEXFile defines the [ExternalReference][1], [InstanceHierarchy][2], [InterfaceClassLib][3], [RoleClassLib][4], [SystemUnitClassLib][5] and [AttributeTypeLib][6] sequences.

  **Namespace:**  [Aml.Engine.CAEX][7]  
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
Type: [System.Int32][8]  
the position

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXWrapper][9]  
The CAEX object.

#### Return Value
Type: [Boolean][10]  
`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`. 
#### Implements
[ICAEXBasicObject.Insert(Int32, CAEXWrapper)][11]  


Remarks
-------
 If the provided CAEX object already has an associated parent, a copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[CAEXFileType Class][12]  
[Aml.Engine.CAEX Namespace][7]  

[1]: ExternalReference.md
[2]: InstanceHierarchy.md
[3]: InterfaceClassLib.md
[4]: RoleClassLib.md
[5]: SystemUnitClassLib.md
[6]: AttributeTypeLib.md
[7]: ../README.md
[8]: https://docs.microsoft.com/dotnet/api/system.int32
[9]: ../CAEXWrapper/README.md
[10]: https://docs.microsoft.com/dotnet/api/system.boolean
[11]: ../ICAEXBasicObject/Insert_1.md
[12]: README.md
[13]: https://www.automationml.org
[14]: ../../icons/logoShade.png