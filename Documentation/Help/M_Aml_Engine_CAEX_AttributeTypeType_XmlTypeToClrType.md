# AttributeTypeType.XmlTypeToClrType Method 
AutomationML 2.1 API 

Gets the CLR type for the specified xmlType. The Mapping is done according to <a href="https://msdn.microsoft.com/en-us/library/xa669bew(v=vs.110).aspx" target="_blank" rel="noopener noreferrer">Mapping XML Data Types to CLR Types.</a>

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static Type XmlTypeToClrType(
	string xmlType
)
```

**VB**<br />
``` VB
Public Shared Function XmlTypeToClrType ( 
	xmlType As String
) As Type
```

**C++**<br />
``` C++
public:
static Type^ XmlTypeToClrType(
	String^ xmlType
)
```


#### Parameters
&nbsp;<dl><dt>xmlType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name of the XML type</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_parent" rel="noopener noreferrer">Type</a><br />a .NET data Type

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>xmlType</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />