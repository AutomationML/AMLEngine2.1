# ObjectWithBaseClass.IsInherited Method 
AutomationML 2.1 API 

Determines, if the specified element is an inherited element. To be an inherited element, it has to be an AttributeType, ExternalInterfaceType or InternalElementType element.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsInherited(
	this IClassWithBaseClassReference classWithBaseClass,
	CAEXBasicObject element
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function IsInherited ( 
	classWithBaseClass As IClassWithBaseClassReference,
	element As CAEXBasicObject
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool IsInherited(
	IClassWithBaseClassReference^ classWithBaseClass, 
	CAEXBasicObject^ element
)
```


#### Parameters
&nbsp;<dl><dt>classWithBaseClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">Aml.Engine.CAEX.IClassWithBaseClassReference</a><br />the class providing the inheritance relation</dd><dt>element</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXBasicObject">Aml.Engine.CAEX.CAEXBasicObject</a><br />the element to test</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if a base class contains the element

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">IClassWithBaseClassReference</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />