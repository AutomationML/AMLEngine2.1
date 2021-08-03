MappingType.Insert Method (CAEXWrapper, Boolean)
================================================
AutomationML 2.1 APIInserts the specified CAEX object in it's associated sequence. The MappingType defines the [InterfaceIDMapping][1], [InterfaceNameMapping][2] and [AttributeNameMapping][3] sequence.

  **Namespace:**  [Aml.Engine.CAEX][4]  
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
Type: [Aml.Engine.CAEX.CAEXWrapper][5]  
The CAEX object.

##### *asFirst* (Optional)
Type: [System.Boolean][6]  
 if set to `true` it is inserted as the first item in its associated sequence.

#### Return Value
Type: [Boolean][6]  
`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`. 
#### Implements
[ICAEXContainer.Insert(CAEXWrapper, Boolean)][7]  
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][8]  


Remarks
-------
 If the provided CAEX object already has an associated parent, a copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[MappingType Class][9]  
[Aml.Engine.CAEX Namespace][4]  

[1]: InterfaceIDMapping.md
[2]: InterfaceNameMapping.md
[3]: AttributeNameMapping.md
[4]: ../README.md
[5]: ../CAEXWrapper/README.md
[6]: https://docs.microsoft.com/dotnet/api/system.boolean
[7]: ../ICAEXContainer/Insert.md
[8]: ../ICAEXBasicObject/Insert.md
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png