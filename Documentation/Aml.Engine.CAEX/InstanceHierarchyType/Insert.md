InstanceHierarchyType.Insert Method (CAEXWrapper, Boolean)
==========================================================
AutomationML 2.1 APIInserts the specified CAEX object in it's associated sequence. The InstanceHierarchy defines the [InternalElement][1] sequence.

  **Namespace:**  [Aml.Engine.CAEX][2]  
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
Type: [Aml.Engine.CAEX.CAEXWrapper][3]  
The CAEX object.

##### *asFirst* (Optional)
Type: [System.Boolean][4]  
 if set to `true` it is inserted as the first item in its associated sequence.

#### Return Value
Type: [Boolean][4]  
`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`. 
#### Implements
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][5]  
[ICAEXContainer.Insert(CAEXWrapper, Boolean)][6]  
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][5]  


Remarks
-------
 If the provided CAEX object already has an associated parent, a copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[InstanceHierarchyType Class][7]  
[Aml.Engine.CAEX Namespace][2]  

[1]: InternalElement.md
[2]: ../README.md
[3]: ../CAEXWrapper/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: ../ICAEXBasicObject/Insert.md
[6]: ../ICAEXContainer/Insert.md
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png