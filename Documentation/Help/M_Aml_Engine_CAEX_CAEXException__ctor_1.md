# CAEXException Constructor (String, Exception)
AutomationML 2.1 API 

Initializes a new instance of the <a href="T_Aml_Engine_CAEX_CAEXException">CAEXException</a> class.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public CAEXException(
	string message,
	Exception innerException
)
```

**VB**<br />
``` VB
Public Sub New ( 
	message As String,
	innerException As Exception
)
```

**C++**<br />
``` C++
public:
CAEXException(
	String^ message, 
	Exception^ innerException
)
```


#### Parameters
&nbsp;<dl><dt>message</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The error message explaining the cause of the exception.</dd><dt>innerException</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.exception" target="_parent" rel="noopener noreferrer">System.Exception</a><br />The exception that caused the current exception, or a null reference ( a null reference (`Nothing` in Visual Basic) in Visual Basic) if no inner exception is specified.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXException">CAEXException Class</a><br /><a href="Overload_Aml_Engine_CAEX_CAEXException__ctor">CAEXException Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />