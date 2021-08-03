# AmlObjectsExtensions.ToRefURIAttribute Method 
AutomationML 2.1 API 

Converts an AttributeType to a RefUriAttribute.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static RefURIAttributeType ToRefURIAttribute(
	this AttributeType attribute
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ToRefURIAttribute ( 
	attribute As AttributeType
) As RefURIAttributeType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static RefURIAttributeType^ ToRefURIAttribute(
	AttributeType^ attribute
)
```


#### Parameters
&nbsp;<dl><dt>attribute</dt><dd>Type: <a href="T_Aml_Engine_CAEX_AttributeType">Aml.Engine.CAEX.AttributeType</a><br />The AttributeType object.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_RefURIAttributeType">RefURIAttributeType</a><br />An RefURIAttributeType object.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Remarks
The conversion doesn't create the RefURIAttributeType. Use <a href="M_Aml_Engine_AmlObjects_RefURIAttributeType_Create">Create(CAEXDocument)</a> method to create a RefURIAttributeType.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions Class</a><br /><a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions Namespace</a><br />