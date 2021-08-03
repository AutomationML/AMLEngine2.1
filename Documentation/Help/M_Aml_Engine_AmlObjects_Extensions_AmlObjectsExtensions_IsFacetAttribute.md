# AmlObjectsExtensions.IsFacetAttribute Method 
AutomationML 2.1 API 

Determines, if the attribute is an attribute of an AMLFacet.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsFacetAttribute(
	this AttributeType facetAttribute
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function IsFacetAttribute ( 
	facetAttribute As AttributeType
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool IsFacetAttribute(
	AttributeType^ facetAttribute
)
```


#### Parameters
&nbsp;<dl><dt>facetAttribute</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />The facet attribute.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if the Attribute belongs to an AMLFacet.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>facetAttribute</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions Class</a><br /><a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions Namespace</a><br />