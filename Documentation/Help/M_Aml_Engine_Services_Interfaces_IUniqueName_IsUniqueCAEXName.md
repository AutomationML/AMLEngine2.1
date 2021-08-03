# IUniqueName.IsUniqueCAEXName Method 
AutomationML 2.1 API 

Determines whether the specified element has a unique CAEX name in the sequence of equal elements of its parent.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
bool IsUniqueCAEXName(
	XElement element
)
```

**VB**<br />
``` VB
Function IsUniqueCAEXName ( 
	element As XElement
) As Boolean
```

**C++**<br />
``` C++
bool IsUniqueCAEXName(
	XElement^ element
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the elements name is unique, otherwise `false`.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IUniqueName">IUniqueName Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />