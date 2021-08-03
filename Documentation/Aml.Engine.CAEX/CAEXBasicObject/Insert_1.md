CAEXBasicObject.Insert Method (Int32, CAEXWrapper)
==================================================
AutomationML 2.1 APIInserts the specified CAEX object in it's associated sequence at the defined position. The CAEXBasicObject defines the [Revision][1] and [SourceObjectInformation][2] sequences.

  **Namespace:**  [Aml.Engine.CAEX][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public virtual bool Insert(
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
#### Implements
[ICAEXBasicObject.Insert(Int32, CAEXWrapper)][7]  


See Also
--------

#### Reference
[CAEXBasicObject Class][8]  
[Aml.Engine.CAEX Namespace][3]  

[1]: Revision.md
[2]: SourceObjectInformation.md
[3]: ../README.md
[4]: https://docs.microsoft.com/dotnet/api/system.int32
[5]: ../CAEXWrapper/README.md
[6]: https://docs.microsoft.com/dotnet/api/system.boolean
[7]: ../ICAEXBasicObject/Insert_1.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png