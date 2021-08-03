CAEXBasicObject.CAEXSequence Method
===================================
Gets the CAEXSequence owned by this instance, which contains the specified CAEX object. For example, if the specified object is a revision object, the sequence of the revision objects [Revision][1] is returned.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual ICAEXSequence CAEXSequence(
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
#### Implements
[ICAEXBasicObject.CAEXSequence(ICAEXWrapper)][5]  


See Also
--------

#### Reference
[CAEXBasicObject Class][6]  
[Aml.Engine.CAEX Namespace][2]  

[1]: Revision.md
[2]: ../README.md
[3]: ../ICAEXWrapper/README.md
[4]: ../ICAEXSequence/README.md
[5]: ../ICAEXBasicObject/CAEXSequence.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png