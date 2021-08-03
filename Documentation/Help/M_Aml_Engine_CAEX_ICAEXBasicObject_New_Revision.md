# ICAEXBasicObject.New_Revision Method 
AutomationML 2.1 API 

Creates a new Revision object and inserts it to the collection of Revision objects <a href="P_Aml_Engine_CAEX_ICAEXBasicObject_Revision">Revision</a> either at the beginning or at the end of the sequence, according to the specified optional value. The Revision object is initialized with the provided values.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
RevisionType New_Revision(
	DateTime date,
	string author,
	bool asFirst = true
)
```

**VB**<br />
``` VB
Function New_Revision ( 
	date As DateTime,
	author As String,
	Optional asFirst As Boolean = true
) As RevisionType
```

**C++**<br />
``` C++
RevisionType^ New_Revision(
	DateTime date, 
	String^ author, 
	bool asFirst = true
)
```


#### Parameters
&nbsp;<dl><dt>date</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.datetime" target="_parent" rel="noopener noreferrer">System.DateTime</a><br />The date.</dd><dt>author</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The author.</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` the created Revision is prepended, otherwise appended.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_RevisionType">RevisionType</a><br />A Revision object.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject Interface</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />