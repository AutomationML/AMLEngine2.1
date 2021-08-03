# SystemUnitClassTypeExtensions.Insert_Attribute Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserts an Attribute object in the Attribute collection of the *objectWithAttributes*.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use Attribute.Insert")]
public static void Insert_Attribute(
	this IObjectWithAttributes objectWithAttributes,
	AttributeType attributeElement
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use Attribute.Insert")>
Public Shared Sub Insert_Attribute ( 
	objectWithAttributes As IObjectWithAttributes,
	attributeElement As AttributeType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use Attribute.Insert")]
static void Insert_Attribute(
	IObjectWithAttributes^ objectWithAttributes, 
	AttributeType^ attributeElement
)
```


#### Parameters
&nbsp;<dl><dt>objectWithAttributes</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">Aml.Engine.CAEX.IObjectWithAttributes</a><br />Any object with an Attribute collection.</dd><dt>attributeElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />The Attribute object to insert</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />