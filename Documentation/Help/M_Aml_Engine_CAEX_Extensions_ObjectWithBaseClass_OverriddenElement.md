# ObjectWithBaseClass.OverriddenElement Method 
AutomationML 2.1 API 

Determines, if an element of a class with an inheritance relation to a base class has an overridden element with the specified name and type, what means a base class contains an element which name is equal to the provided elementName.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static XElement OverriddenElement(
	this IClassWithBaseClassReference classWithBaseClass,
	string elementName,
	Type elementType
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function OverriddenElement ( 
	classWithBaseClass As IClassWithBaseClassReference,
	elementName As String,
	elementType As Type
) As XElement
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static XElement^ OverriddenElement(
	IClassWithBaseClassReference^ classWithBaseClass, 
	String^ elementName, 
	Type^ elementType
)
```


#### Parameters
&nbsp;<dl><dt>classWithBaseClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">Aml.Engine.CAEX.IClassWithBaseClassReference</a><br />the base class containing the element</dd><dt>elementName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the element.</dd><dt>elementType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_parent" rel="noopener noreferrer">System.Type</a><br />Type of the element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a><br />The overridden element if it exists; otherwise `null`.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">IClassWithBaseClassReference</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />