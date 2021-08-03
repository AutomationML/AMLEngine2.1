CAEXFileType.Insert Method (CAEXWrapper, Boolean)
=================================================
Inserts the specified CAEX object in it's associated sequence. The CAEXFile defines the [ExternalReference][1], [InstanceHierarchy][2], [InterfaceClassLib][3], [RoleClassLib][4], [SystemUnitClassLib][5] and [AttributeTypeLib][6] sequences.

  **Namespace:**  [Aml.Engine.CAEX][7]  
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
Type: [Aml.Engine.CAEX.CAEXWrapper][8]  
The CAEX object.

##### *asFirst* (Optional)
Type: [System.Boolean][9]  
 if set to `true` it is inserted as the first item in its associated sequence.

#### Return Value
Type: [Boolean][9]  
`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`. 
#### Implements
[ICAEXContainer.Insert(CAEXWrapper, Boolean)][10]  
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][11]  


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
[8]: ../CAEXWrapper/README.md
[9]: https://docs.microsoft.com/dotnet/api/system.boolean
[10]: ../ICAEXContainer/Insert.md
[11]: ../ICAEXBasicObject/Insert.md
[12]: README.md
[13]: https://www.automationml.org
[14]: ../../icons/logoShade.png