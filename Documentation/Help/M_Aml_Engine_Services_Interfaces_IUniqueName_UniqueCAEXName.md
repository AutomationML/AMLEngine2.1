# IUniqueName.UniqueCAEXName Method (XElement, String)
AutomationML 2.1 API 

Creates a unique CAEX Name for a child with the specified elementTagName in the specified sequence

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
string UniqueCAEXName(
	XElement sequence,
	string elementTagName
)
```

**VB**<br />
``` VB
Function UniqueCAEXName ( 
	sequence As XElement,
	elementTagName As String
) As String
```

**C++**<br />
``` C++
String^ UniqueCAEXName(
	XElement^ sequence, 
	String^ elementTagName
)
```


#### Parameters
&nbsp;<dl><dt>sequence</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The sequence of elements.</dd><dt>elementTagName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the element tag.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />a unique name using the registered default extended with an added number, representing the maximal number

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IUniqueName">IUniqueName Interface</a><br /><a href="Overload_Aml_Engine_Services_Interfaces_IUniqueName_UniqueCAEXName">UniqueCAEXName Overload</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />