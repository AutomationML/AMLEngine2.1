# CAEXPathBuilder.PathPartSeparator Method (CAEXObject)
AutomationML 2.1 API 

Returns the Path part separator for an element, which should be put before that element in a Path

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static char PathPartSeparator(
	CAEXObject element
)
```

**VB**<br />
``` VB
Public Shared Function PathPartSeparator ( 
	element As CAEXObject
) As Char
```

**C++**<br />
``` C++
public:
static wchar_t PathPartSeparator(
	CAEXObject^ element
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXObject">Aml.Engine.CAEX.CAEXObject</a><br />The CAEX-Element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.char" target="_parent" rel="noopener noreferrer">Char</a><br />The Path Separation character for the given element

## Remarks
Since CAEX Version 3.0 the PathPartSeparator is element independent and always the <a href="F_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_ObjectSeparator">ObjectSeparator</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPartSeparator">PathPartSeparator Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />