# AttributeTypeTypeExtensions.IsMaster Method 
AutomationML 2.1 API 

Determines whether the specified Attribute is referenced by other Attribute objects called 'Mirrors'.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsMaster(
	this AttributeType element
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function IsMaster ( 
	element As AttributeType
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool IsMaster(
	AttributeType^ element
)
```


#### Parameters
&nbsp;<dl><dt>element</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />The element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if the specified element is a 'Master'-Attribute; otherwise, `false`.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_AttributeTypeTypeExtensions">AttributeTypeTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />