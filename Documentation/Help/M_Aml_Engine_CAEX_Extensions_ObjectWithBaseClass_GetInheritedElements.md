# ObjectWithBaseClass.GetInheritedElements Method 
AutomationML 2.1 API 

Gets a collection of InternalElement objects that are inherited from base classes. As default, the own InternalElements are included in the enumeration.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<InternalElementType> GetInheritedElements(
	this SystemUnitFamilyType classWithBaseClass,
	bool includeSelf = true
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function GetInheritedElements ( 
	classWithBaseClass As SystemUnitFamilyType,
	Optional includeSelf As Boolean = true
) As IEnumerable(Of InternalElementType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<InternalElementType^>^ GetInheritedElements(
	SystemUnitFamilyType^ classWithBaseClass, 
	bool includeSelf = true
)
```


#### Parameters
&nbsp;<dl><dt>classWithBaseClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">Aml.Engine.CAEX.SystemUnitFamilyType</a><br />The class with a possible base class reference for inheritance.</dd><dt>includeSelf (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` includes the own Internal Elements.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>)<br />A collection of InternalElement objects

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />