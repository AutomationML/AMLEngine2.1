CAEXBasicObject.New_Revision Method
===================================
AutomationML 2.1 APICreates a new Revision object and inserts it to the collection of Revision objects [Revision][1] either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values.

  **Namespace:**  [Aml.Engine.CAEX][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public RevisionType New_Revision(
	DateTime date,
	string author,
	bool asFirst = true
)
```

#### Parameters

##### *date*
Type: [System.DateTime][3]  
The date.

##### *author*
Type: [System.String][4]  
The author.

##### *asFirst* (Optional)
Type: [System.Boolean][5]  
if set to `true` the created Revision is prepended, otherwise appended.

#### Return Value
Type: [RevisionType][6]  
A Revision object.
#### Implements
[ICAEXBasicObject.New_Revision(DateTime, String, Boolean)][7]  


See Also
--------

#### Reference
[CAEXBasicObject Class][8]  
[Aml.Engine.CAEX Namespace][2]  

[1]: Revision.md
[2]: ../README.md
[3]: https://docs.microsoft.com/dotnet/api/system.datetime
[4]: https://docs.microsoft.com/dotnet/api/system.string
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: ../RevisionType/README.md
[7]: ../ICAEXBasicObject/New_Revision.md
[8]: README.md
[9]: https://www.automationml.org
[10]: ../../icons/logoShade.png