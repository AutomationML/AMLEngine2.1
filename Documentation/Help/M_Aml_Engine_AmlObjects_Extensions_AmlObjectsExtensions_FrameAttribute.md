# AmlObjectsExtensions.FrameAttribute Method 
AutomationML 2.1 API 

Gets a defined FrameAttribute from the <a href="P_Aml_Engine_CAEX_IObjectWithAttributes_Attribute">Attribute</a> collection of the <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>. If no such attribute exists, `null` is returned.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static FrameAttributeType FrameAttribute(
	this IObjectWithAttributes caexObject
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function FrameAttribute ( 
	caexObject As IObjectWithAttributes
) As FrameAttributeType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static FrameAttributeType^ FrameAttribute(
	IObjectWithAttributes^ caexObject
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">Aml.Engine.CAEX.IObjectWithAttributes</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_FrameAttributeType">FrameAttributeType</a><br />The FrameAttribute.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions Class</a><br /><a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions Namespace</a><br />