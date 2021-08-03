# ObjectWithBaseClass.DeleteInheritedElement Method 
AutomationML 2.1 API 

Deletes the inherited element. According to CAEX [DIN EN 62424:2008-08 A.2.4.1 (pp.48-49)], deleting of inherited properties is possible by redefinition of the corresponding data again in the child object with the ChangeMode attribute set to "deleted".

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool DeleteInheritedElement(
	this IClassWithBaseClassReference classWithBaseClass,
	string elementName,
	Type elementType
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function DeleteInheritedElement ( 
	classWithBaseClass As IClassWithBaseClassReference,
	elementName As String,
	elementType As Type
) As Boolean
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static bool DeleteInheritedElement(
	IClassWithBaseClassReference^ classWithBaseClass, 
	String^ elementName, 
	Type^ elementType
)
```


#### Parameters
&nbsp;<dl><dt>classWithBaseClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">Aml.Engine.CAEX.IClassWithBaseClassReference</a><br />The class with base class.</dd><dt>elementName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the element which should be deleted.</dd><dt>elementType</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_parent" rel="noopener noreferrer">System.Type</a><br />Type of the element which should be deleted.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />true, if an inherited property was found and could be deleted; otherwise false.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_IClassWithBaseClassReference">IClassWithBaseClassReference</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_ObjectWithBaseClass">ObjectWithBaseClass Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />