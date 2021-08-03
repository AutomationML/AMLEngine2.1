# InheritanceExtensions.ClassIsDerivedFrom(*T*) Method (IClassWithBaseClassReference(*T*), IClassWithBaseClassReference(*T*))
AutomationML 2.1 API 

Determines, if the specified class is directly or indirectly (across multiple generations) a descendant of the specified base class or identical to it. This method can be used, if the classes are distributed over different CAEX documents, the documents should be referenced by external references and alias references.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool? ClassIsDerivedFrom<T>(
	this IClassWithBaseClassReference<T> classWithReference,
	IClassWithBaseClassReference<T> baseClass
)
where T : CAEXObject

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ClassIsDerivedFrom(Of T As CAEXObject) ( 
	classWithReference As IClassWithBaseClassReference(Of T),
	baseClass As IClassWithBaseClassReference(Of T)
) As Boolean?
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
generic<typename T>
where T : CAEXObject
static Nullable<bool> ClassIsDerivedFrom(
	IClassWithBaseClassReference<T>^ classWithReference, 
	IClassWithBaseClassReference<T>^ baseClass
)
```


#### Parameters
&nbsp;<dl><dt>classWithReference</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference_1">Aml.Engine.CAEX.IClassWithBaseClassReference</a>(*T*)<br />The class with reference.</dd><dt>baseClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference_1">Aml.Engine.CAEX.IClassWithBaseClassReference</a>(*T*)<br />The base class.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>The type of the CAEX class.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.nullable-1" target="_parent" rel="noopener noreferrer">Nullable</a>(<a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a>)<br />`true` if the class is derived, `false` if it is not. If no value is returned, some references could not be resolved to get the answer.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference_1">IClassWithBaseClassReference</a>(*T*). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_InheritanceExtensions">InheritanceExtensions Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_InheritanceExtensions_ClassIsDerivedFrom">ClassIsDerivedFrom Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />