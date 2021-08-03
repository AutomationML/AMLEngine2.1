ICAEXBasicObject.CAEXSequence Method
====================================
AutomationML 2.1 APIGets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][1] is returned.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
ICAEXSequence CAEXSequence(
	ICAEXWrapper caexObject
)
```

#### Parameters

##### *caexObject*
Type: [Aml.Engine.CAEX.ICAEXWrapper][3]  
The CAEX object, contained in a sequence, owned by this CAEX object.

#### Return Value
Type: [ICAEXSequence][4]  
The CAEX sequence or null, if no sequence exists, containing the specified CAEX object.

See Also
--------

#### Reference
[ICAEXBasicObject Interface][5]  
[Aml.Engine.CAEX Namespace][2]  

[1]: Revision.md
[2]: ../README.md
[3]: ../ICAEXWrapper/README.md
[4]: ../ICAEXSequence/README.md
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png