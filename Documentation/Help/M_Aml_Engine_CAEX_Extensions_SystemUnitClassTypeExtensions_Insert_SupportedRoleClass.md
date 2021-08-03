# SystemUnitClassTypeExtensions.Insert_SupportedRoleClass Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserts the SupportedRoleClass as the first SupportedRoleClass if nothing else if explicit defined.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use SupportedRoleClass.Insert")]
public static void Insert_SupportedRoleClass(
	this SystemUnitClassType systemUnitClass,
	SupportedRoleClassType supportedRoleClassElement,
	bool asFirst = true
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use SupportedRoleClass.Insert")>
Public Shared Sub Insert_SupportedRoleClass ( 
	systemUnitClass As SystemUnitClassType,
	supportedRoleClassElement As SupportedRoleClassType,
	Optional asFirst As Boolean = true
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use SupportedRoleClass.Insert")]
static void Insert_SupportedRoleClass(
	SystemUnitClassType^ systemUnitClass, 
	SupportedRoleClassType^ supportedRoleClassElement, 
	bool asFirst = true
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />The SystemUnitClass object</dd><dt>supportedRoleClassElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SupportedRoleClassType">Aml.Engine.CAEX.SupportedRoleClassType</a><br />The supported role class element.</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />Inserted at first position if set to `true`, otherwise appended at last position</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />