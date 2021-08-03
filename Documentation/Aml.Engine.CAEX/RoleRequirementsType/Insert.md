RoleRequirementsType.Insert Method (CAEXWrapper, Boolean)
=========================================================
AutomationML 2.1 APIInserts the specified CAEX object in it's associated sequence. The RoleRequirementsType defines the [Attribute][1] and [ExternalInterface][2] sequence.

  **Namespace:**  [Aml.Engine.CAEX][3]  
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
Type: [Aml.Engine.CAEX.CAEXWrapper][4]  
The CAEX object.

##### *asFirst* (Optional)
Type: [System.Boolean][5]  
 if set to `true` it is inserted as the first item in its associated sequence.

#### Return Value
Type: [Boolean][5]  
`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`. 
#### Implements
[ICAEXContainer.Insert(CAEXWrapper, Boolean)][6]  
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][7]  


Remarks
-------
 If the provided CAEX object already has an associated parent, a copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[RoleRequirementsType Class][8]  
[Aml.Engine.CAEX Namespace][3]  

[1]: Attribute.md
[2]: ExternalInterface.md
[3]: ../README.md
[4]: ../CAEXWrapper/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: ../ICAEXContainer/Insert.md
[7]: ../ICAEXBasicObject/Insert.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png