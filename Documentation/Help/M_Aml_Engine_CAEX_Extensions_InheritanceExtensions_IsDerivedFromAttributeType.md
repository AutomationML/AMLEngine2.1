# InheritanceExtensions.IsDerivedFromAttributeType Method 
AutomationML 2.1 API 

Determines whether the specified attribute defines an inheritance relation from the attribute, uniquely identifiable by the given attribute type path. The attribute type path may contain an alias.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsDerivedFromAttributeType(
	this AttributeTypeType attribute,
	string attributeTypePath
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function IsDerivedFromAttributeType ( 
	attribute As AttributeTypeType,
	attributeTypePath As String
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool IsDerivedFromAttributeType(
	AttributeTypeType^ attribute, 
	String^ attributeTypePath
)
```


#### Parameters
&nbsp;<dl><dt>attribute</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeTypeType">Aml.Engine.CAEX.AttributeTypeType</a><br />The attribute, containing a reference - this is either an Attribute or an AttributeType.</dd><dt>attributeTypePath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />A class path of a base attribute type, which is tested for a possible inheritance relation to the specified attribute.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if an inheritance relation is resolved; otherwise, `false`.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_AttributeTypeType">AttributeTypeType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_InheritanceExtensions">InheritanceExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />