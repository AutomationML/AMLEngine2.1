# AmlObjectsExtensions.AMLFacet Method 
AutomationML 2.1 API 

Converts an InternalElementType to an AMLFacet.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static AMLFacet AMLFacet(
	this InternalElementType internalElement
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AMLFacet ( 
	internalElement As InternalElementType
) As AMLFacet
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static AMLFacet^ AMLFacet(
	InternalElementType^ internalElement
)
```


#### Parameters
&nbsp;<dl><dt>internalElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The InternalElement object.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_AMLFacet">AMLFacet</a><br />An AMLFacet object.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Remarks
The conversion doesn't create the AMLFacet. Use <a href="M_Aml_Engine_AmlObjects_AMLFacet_Create">Create(CAEXDocument, String)</a> method to create a Facet.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions Class</a><br /><a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions Namespace</a><br />