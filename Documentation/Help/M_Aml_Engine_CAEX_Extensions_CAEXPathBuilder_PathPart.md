# CAEXPathBuilder.PathPart Method (CAEXObject, Boolean)
AutomationML 2.1 API 

Builds the Path Part for any CAEXObject, which may be part of a CAEX Path. The Path Part is build from the object Names and the Part - Syntax, according to chapter 2.8 of the CAEX guide: If defined separators are potentially a valid part of object names, the following syntax shall be used: all path elements shall be separated by square brackets “[“ name “]”. This allows for using the original names and the defined separators at the same time. If the conflict case arises that the described brackets are part of object names, the brackets in the object name shall be escaped by means of common XML escape-sequences. If a name contains any Path part - Separator like '[' or ]' this character will be escaped with '\'.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string PathPart(
	CAEXObject element,
	bool useId = false
)
```

**VB**<br />
``` VB
Public Shared Function PathPart ( 
	element As CAEXObject,
	Optional useId As Boolean = false
) As String
```

**C++**<br />
``` C++
public:
static String^ PathPart(
	CAEXObject^ element, 
	bool useId = false
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXObject">Aml.Engine.CAEX.CAEXObject</a><br />The CAEX element which should be part of the Path.</dd><dt>useId (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if true, the path part is build with the ID-Attribute</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The Element Representation in the CAEX Path

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPart">PathPart Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />