# SystemUnitClassTypeExtensions.Ancestors Method 
AutomationML 2.1 API 

Returns all SystemUnit Classes which are ancestors of this. This SystemUnit Class is included in the enumeration as the first Element, The farthest is the last Element in the enumeration.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<SystemUnitFamilyType> Ancestors(
	this SystemUnitFamilyType systemUnitClass
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function Ancestors ( 
	systemUnitClass As SystemUnitFamilyType
) As IEnumerable(Of SystemUnitFamilyType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<SystemUnitFamilyType^>^ Ancestors(
	SystemUnitFamilyType^ systemUnitClass
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">Aml.Engine.CAEX.SystemUnitFamilyType</a><br />The SystemUnitClass.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a>)<br />Enumeration of all SystemUnitClass ancestors.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />