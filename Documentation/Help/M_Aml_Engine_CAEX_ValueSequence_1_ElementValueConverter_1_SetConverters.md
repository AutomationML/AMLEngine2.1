# ValueSequence(*TDataType*).ElementValueConverter(*T*).SetConverters Method 
AutomationML 2.1 API 

Sets custom value converters to support conversion from objects to user defined types.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public void SetConverters(
	Func<XElement, T> convertFrom,
	Func<T, Object> convertTo
)
```

**VB**<br />
``` VB
Public Sub SetConverters ( 
	convertFrom As Func(Of XElement, T),
	convertTo As Func(Of T, Object)
)
```

**C++**<br />
``` C++
public:
void SetConverters(
	Func<XElement^, T>^ convertFrom, 
	Func<T, Object^>^ convertTo
)
```


#### Parameters
&nbsp;<dl><dt>convertFrom</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.func-2" target="_parent" rel="noopener noreferrer">System.Func</a>(<a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a>, <a href="T_Aml_Engine_CAEX_ValueSequence_1_ElementValueConverter_1">*T*</a>)<br />The convert from.</dd><dt>convertTo</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.func-2" target="_parent" rel="noopener noreferrer">System.Func</a>(<a href="T_Aml_Engine_CAEX_ValueSequence_1_ElementValueConverter_1">*T*</a>, <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">Object</a>)<br />The convert to.</dd></dl>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ValueSequence_1_ElementValueConverter_1">ValueSequence(TDataType).ElementValueConverter(T) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />