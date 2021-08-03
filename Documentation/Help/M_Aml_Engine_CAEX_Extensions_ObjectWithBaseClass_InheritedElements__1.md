# ObjectWithBaseClass.InheritedElements(*TInheritedElement*) Method 
AutomationML 2.1 API 

Gets a collection of objects of the defined InheritedElement-Type that are inherited from base classes.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<TInheritedElement> InheritedElements<TInheritedElement>(
	this IClassWithBaseClassReference classWithBaseClass,
	bool includeSelf = true
)
where TInheritedElement : CAEXBasicObject

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function InheritedElements(Of TInheritedElement As CAEXBasicObject) ( 
	classWithBaseClass As IClassWithBaseClassReference,
	Optional includeSelf As Boolean = true
) As IEnumerable(Of TInheritedElement)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
generic<typename TInheritedElement>
where TInheritedElement : CAEXBasicObject
static IEnumerable<TInheritedElement>^ InheritedElements(
	IClassWithBaseClassReference^ classWithBaseClass, 
	bool includeSelf = true
)
```


#### Parameters
&nbsp;<dl><dt>classWithBaseClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">Aml.Engine.CAEX.IClassWithBaseClassReference</a><br />the base class containing the element</dd><dt>includeSelf (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` the own elements are included.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>TInheritedElement</dt><dd>The type of the inherited element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(*TInheritedElement*)<br />An enumeration of all inherited elements.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">IClassWithBaseClassReference</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />