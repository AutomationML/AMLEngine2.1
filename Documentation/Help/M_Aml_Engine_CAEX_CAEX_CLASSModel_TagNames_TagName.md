# CAEX_CLASSModel_TagNames.TagName Method 
AutomationML 2.1 API 

gets the CAEX-Tag name for the CAEX-wrapper type.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string TagName(
	Type caexWrapperType
)
```

**VB**<br />
``` VB
Public Shared Function TagName ( 
	caexWrapperType As Type
) As String
```

**C++**<br />
``` C++
public:
static String^ TagName(
	Type^ caexWrapperType
)
```


#### Parameters
&nbsp;<dl><dt>caexWrapperType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_parent" rel="noopener noreferrer">System.Type</a><br />Type of the CAEX wrapper.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />System.String.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexWrapperType</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames">CAEX_CLASSModel_TagNames Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />