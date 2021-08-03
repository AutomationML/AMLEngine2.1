ICAEXBasicObject.Insert Method (CAEXWrapper, Boolean)
=====================================================
AutomationML 2.1 APIInserts the specified CAEX object in it's associated sequence. The CAEXBasicObject defines the [Revision][1] and [SourceObjectInformation][2] sequences.

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
bool Insert(
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

See Also
--------

#### Reference
[ICAEXBasicObject Interface][6]  
[Aml.Engine.CAEX Namespace][3]  

[1]: Revision.md
[2]: SourceObjectInformation.md
[3]: ../README.md
[4]: ../CAEXWrapper/README.md
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png