# InstanceHierarchyTypeExtensions.InternalElementDescendants Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Gets all descendant <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a> Objects in the InstanceHierarchy. InternalElements on all levels are returned.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use instanceHierarchy.Descendants<InternalElementType> instead.")]
public static IEnumerable<InternalElementType> InternalElementDescendants(
	this InstanceHierarchyType instanceHierarchy
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use instanceHierarchy.Descendants<InternalElementType> instead.")>
Public Shared Function InternalElementDescendants ( 
	instanceHierarchy As InstanceHierarchyType
) As IEnumerable(Of InternalElementType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use instanceHierarchy.Descendants<InternalElementType> instead.")]
static IEnumerable<InternalElementType^>^ InternalElementDescendants(
	InstanceHierarchyType^ instanceHierarchy
)
```


#### Parameters
&nbsp;<dl><dt>instanceHierarchy</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InstanceHierarchyType">Aml.Engine.CAEX.InstanceHierarchyType</a><br />The InstanceHierarchy.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>)<br />Enumeration of the InternalElement objects.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_InstanceHierarchyType">InstanceHierarchyType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_InstanceHierarchyTypeExtensions">InstanceHierarchyTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />