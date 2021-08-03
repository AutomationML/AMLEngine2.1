ICAEXBasicObject.Insert Method (Int32, CAEXWrapper)
===================================================
Inserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][1] and [SourceObjectInformation][2] sequences.

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
bool Insert(
	int pos,
	CAEXWrapper caexObject
)
```

#### Parameters

##### *pos*
Type: [System.Int32][4]  
The position

##### *caexObject*
Type: [Aml.Engine.CAEX.CAEXWrapper][5]  
The CAEX object.

#### Return Value
Type: [Boolean][6]  
 true, if a sequence could be identified and the CAEX object has been inserted into this sequence. 

See Also
--------

#### Reference
[ICAEXBasicObject Interface][7]  
[Aml.Engine.CAEX Namespace][3]  

[1]: Revision.md
[2]: SourceObjectInformation.md
[3]: ../README.md
[4]: https://docs.microsoft.com/dotnet/api/system.int32
[5]: ../CAEXWrapper/README.md
[6]: https://docs.microsoft.com/dotnet/api/system.boolean
[7]: README.md
[8]: https://www.automationml.org
[9]: ../../icons/logoShade.png