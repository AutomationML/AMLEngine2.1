# AmlObjectsExtensions.New_FrameAttribute Method 
AutomationML 2.1 API 

Creates a new Frame attribute for the <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a> if no Frame attribute exists. The provided values are used to initialize the Frame attribute values.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static FrameAttributeType New_FrameAttribute(
	this IObjectWithAttributes caexObject,
	FrameValues frameValues = null
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_FrameAttribute ( 
	caexObject As IObjectWithAttributes,
	Optional frameValues As FrameValues = Nothing
) As FrameAttributeType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static FrameAttributeType^ New_FrameAttribute(
	IObjectWithAttributes^ caexObject, 
	FrameValues^ frameValues = nullptr
)
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">Aml.Engine.CAEX.IObjectWithAttributes</a><br />The CAEX object.</dd><dt>frameValues (Optional)</dt><dd>Type: <a href="T_Aml_Engine_AmlObjects_FrameValues">Aml.Engine.AmlObjects.FrameValues</a><br />The frame values.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_AmlObjects_FrameAttributeType">FrameAttributeType</a><br />the new FrameAttributeType.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>caexObject</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_Extensions_AmlObjectsExtensions">AmlObjectsExtensions Class</a><br /><a href="N_Aml_Engine_AmlObjects_Extensions">Aml.Engine.AmlObjects.Extensions Namespace</a><br />