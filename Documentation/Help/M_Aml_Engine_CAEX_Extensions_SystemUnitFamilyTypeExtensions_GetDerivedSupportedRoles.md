# SystemUnitFamilyTypeExtensions.GetDerivedSupportedRoles Method 
AutomationML 2.1 API 

Gets the supported Roles and the inherited roles from base classes.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static List<SupportedRoleClassType> GetDerivedSupportedRoles(
	this SystemUnitFamilyType systemUnitClass,
	bool includeOwn = true
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function GetDerivedSupportedRoles ( 
	systemUnitClass As SystemUnitFamilyType,
	Optional includeOwn As Boolean = true
) As List(Of SupportedRoleClassType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static List<SupportedRoleClassType^>^ GetDerivedSupportedRoles(
	SystemUnitFamilyType^ systemUnitClass, 
	bool includeOwn = true
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">Aml.Engine.CAEX.SystemUnitFamilyType</a><br />\[Missing <param name="systemUnitClass"/> documentation for "M:Aml.Engine.CAEX.Extensions.SystemUnitFamilyTypeExtensions.GetDerivedSupportedRoles(Aml.Engine.CAEX.SystemUnitFamilyType,System.Boolean)"\]</dd><dt>includeOwn (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />\[Missing <param name="includeOwn"/> documentation for "M:Aml.Engine.CAEX.Extensions.SystemUnitFamilyTypeExtensions.GetDerivedSupportedRoles(Aml.Engine.CAEX.SystemUnitFamilyType,System.Boolean)"\]</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1" target="_parent" rel="noopener noreferrer">List</a>(<a href="T_Aml_Engine_CAEX_SupportedRoleClassType">SupportedRoleClassType</a>)<br />List<SupportedRoleClassType>.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitFamilyTypeExtensions">SystemUnitFamilyTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />