AMLGroup.Insert Method (CAEXWrapper, Boolean)
=============================================
AutomationML 2.1 APIInserts the specified CAEX object in it's associated container. An AMLGroup object shall only contain InternalElements which are AMLMirrorObjects and/or further AMLGroup objects. If other InternalElements are tried to insert, the result is `false`.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
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
Type: [Aml.Engine.CAEX.CAEXWrapper][2]  
The CAEX object.

##### *asFirst* (Optional)
Type: [System.Boolean][3]  
if set to `true` the element is inserted at the first position in it's container.

#### Return Value
Type: [Boolean][3]  
`true`, if the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`. 
#### Implements
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][4]  
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][4]  
[ICAEXContainer.Insert(CAEXWrapper, Boolean)][5]  
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][4]  


Exceptions
----------

Exception                  | Condition  
-------------------------- | ---------- 
[ArgumentNullException][6] | caexObject 


Remarks
-------
 If the provided CAEX object already has an associated parent, a copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified. 

See Also
--------

#### Reference
[AMLGroup Class][7]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/CAEXWrapper/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: ../../Aml.Engine.CAEX/ICAEXBasicObject/Insert.md
[5]: ../../Aml.Engine.CAEX/ICAEXContainer/Insert.md
[6]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png