# ObjectWithBaseClass.ReferencedClassName Method (IClassWithBaseClassReference)
AutomationML 2.1 API 

Name of the referenced Class without path information.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string ReferencedClassName(
	this IClassWithBaseClassReference objectWithClassReference
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ReferencedClassName ( 
	objectWithClassReference As IClassWithBaseClassReference
) As String
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static String^ ReferencedClassName(
	IClassWithBaseClassReference^ objectWithClassReference
)
```


#### Parameters
&nbsp;<dl><dt>objectWithClassReference</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">Aml.Engine.CAEX.IClassWithBaseClassReference</a><br />Any object with a class reference.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />Name of the referenced Class, if exists; otherwise `string.Empty`

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">IClassWithBaseClassReference</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass_ReferencedClassName">ReferencedClassName Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />