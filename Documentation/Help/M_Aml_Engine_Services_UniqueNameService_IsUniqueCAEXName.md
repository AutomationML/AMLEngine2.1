# UniqueNameService.IsUniqueCAEXName Method 
AutomationML 2.1 API 

Determines whether the specified element has a unique CAEX name in the sequence of equal elements of its parent.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool IsUniqueCAEXName(
	XElement element
)
```

**VB**<br />
``` VB
Public Function IsUniqueCAEXName ( 
	element As XElement
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool IsUniqueCAEXName(
	XElement^ element
) sealed
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the elements name is unique, otherwise `false`.

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IUniqueName_IsUniqueCAEXName">IUniqueName.IsUniqueCAEXName(XElement)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_UniqueNameService">UniqueNameService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />