CAEXBasicObject.Insert Method (CAEXWrapper, Boolean)
====================================================
Inserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][1] and [SourceObjectInformation][2] sequences.

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual bool Insert(
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
 true, if a sequence could be identified and the CAEX object has been inserted into this sequence. 
#### Implements
[ICAEXContainer.Insert(CAEXWrapper, Boolean)][6]  
[ICAEXBasicObject.Insert(CAEXWrapper, Boolean)][7]  


See Also
--------

#### Reference
[CAEXBasicObject Class][8]  
[Aml.Engine.CAEX Namespace][3]  

[1]: Revision.md
[2]: SourceObjectInformation.md
[3]: ../README.md
[4]: ../CAEXWrapper/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: ../ICAEXContainer/Insert.md
[7]: ../ICAEXBasicObject/Insert.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png