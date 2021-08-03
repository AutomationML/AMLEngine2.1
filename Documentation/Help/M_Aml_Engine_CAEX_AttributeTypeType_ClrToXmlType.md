# AttributeTypeType.ClrToXmlType Method 
AutomationML 2.1 API 

Gets the xmlType type for the specified CLR type. The Mapping is done according to <a href="https://msdn.microsoft.com/en-us/library/xa669bew(v=vs.110).aspx" target="_blank" rel="noopener noreferrer">Mapping XML Data Types to CLR Types.</a> This reverse mapping is not unambiguous. If more than one mapping is possible, the most common used description is generated. If No mapping is defined the 'xs:string' is used.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string ClrToXmlType(
	Type clrType
)
```

**VB**<br />
``` VB
Public Shared Function ClrToXmlType ( 
	clrType As Type
) As String
```

**C++**<br />
``` C++
public:
static String^ ClrToXmlType(
	Type^ clrType
)
```


#### Parameters
&nbsp;<dl><dt>clrType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_parent" rel="noopener noreferrer">System.Type</a><br />.Net data Type.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />the name of the XML type

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>clrType</td></tr></table>

## Remarks
You can use the encoding and decoding methods of the <a href="T_Aml_Engine_CAEX_Extensions_CaexValue">CaexValue</a> object, to receive a type conform result for the attribute value elements.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />