# CAEXPathBuilder.InternalLinkReferencePath Method (XElement, XElement)
AutomationML 2.1 API 

gets the reference path for an Interface-Reference in an InternalLink

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string InternalLinkReferencePath(
	XElement interfaceParent,
	XElement externalInterface
)
```

**VB**<br />
``` VB
Public Shared Function InternalLinkReferencePath ( 
	interfaceParent As XElement,
	externalInterface As XElement
) As String
```

**C++**<br />
``` C++
public:
static String^ InternalLinkReferencePath(
	XElement^ interfaceParent, 
	XElement^ externalInterface
)
```


#### Parameters
&nbsp;<dl><dt>interfaceParent</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The interface Parent (SystemUnitClass or InternalElement)</dd><dt>externalInterface</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">System.Xml.Linq.XElement</a><br />The external Interface.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />System.String.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_InternalLinkReferencePath">InternalLinkReferencePath Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />