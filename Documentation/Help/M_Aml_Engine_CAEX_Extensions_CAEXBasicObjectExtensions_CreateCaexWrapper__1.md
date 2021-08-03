# CAEXBasicObjectExtensions.CreateCaexWrapper(*T*) Method 
AutomationML 2.1 API 

Creates a CAEX object of the given type from the specified XML element.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static T CreateCaexWrapper<T>(
	XElement xmlNode
)
where T : CAEXWrapper

```

**VB**<br />
``` VB
Public Shared Function CreateCaexWrapper(Of T As CAEXWrapper) ( 
	xmlNode As XElement
) As T
```

**C++**<br />
``` C++
public:
generic<typename T>
where T : CAEXWrapper
static T CreateCaexWrapper(
	XElement^ xmlNode
)
```


#### Parameters
&nbsp;<dl><dt>xmlNode</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The XML node.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>CAEX element type.</dd></dl>

#### Return Value
Type: *T*<br />CAEX object in the given type.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXBasicObjectExtensions">CAEXBasicObjectExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />