SystemUnitClassType.Insert Method (CAEXWrapper, Boolean)
========================================================
Inserts the specified CAEX object in it's associated sequence. The SystemUnitClass defines the [Attribute][1], [ExternalInterface][2], [InternalElement][3], [InternalLink][4], and [SupportedRoleClass][5] sequence.

  **Namespace:**  [Aml.Engine.CAEX][6]  
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
Type: [Aml.Engine.CAEX.CAEXWrapper][7]  
The CAEX object.

##### *asFirst* (Optional)
Type: [System.Boolean][8]  
 if set to `true` it is inserted as the first item in its associated sequence.

#### Return Value
Type: [Boolean][8]  
`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`. 
#### Implements
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][9]  
[ICAEXContainer.Insert(CAEXWrapper, Boolean)][10]  
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][9]  


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
[7]: ../CAEXWrapper/README.md
[8]: https://docs.microsoft.com/dotnet/api/system.boolean
[9]: ../ICAEXBasicObject/Insert.md
[10]: ../ICAEXContainer/Insert.md
[11]: README.md
[12]: https://www.automationml.org
[13]: ../../icons/logoShade.png