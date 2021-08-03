RoleClassType.Insert Method (Int32, CAEXWrapper)
================================================
Inserts the specified CAEX object in it's associated sequence. The RoleClass defines the [Attribute][1] and [ExternalInterface][2] sequence.

  **Namespace:**  [Aml.Engine.CAEX][3]  
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
Type: [System.Int32][4]  


##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXWrapper][5]  
The CAEX object.

#### Return Value
Type: [Boolean][6]  
`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`. 
#### Implements
[ICAEXBasicObject.Insert(Int32, CAEXWrapper)][7]  


Remarks
-------
 If the provided CAEX object already has an associated parent, a copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[RoleClassType Class][8]  
[Aml.Engine.CAEX Namespace][3]  

[1]: Attribute.md
[2]: ExternalInterface.md
[3]: ../README.md
[4]: https://docs.microsoft.com/dotnet/api/system.int32
[5]: ../CAEXWrapper/README.md
[6]: https://docs.microsoft.com/dotnet/api/system.boolean
[7]: ../ICAEXBasicObject/Insert_1.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png