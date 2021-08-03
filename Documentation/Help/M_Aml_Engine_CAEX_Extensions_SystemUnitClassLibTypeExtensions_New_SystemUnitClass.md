# SystemUnitClassLibTypeExtensions.New_SystemUnitClass Method 
AutomationML 2.1 API 

Adding a new SystemUnitClass to this SystemUnitClassLib.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static SystemUnitFamilyType New_SystemUnitClass(
	this SystemUnitClassLibType systemUnitClassLib,
	string systemUnitClassName
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_SystemUnitClass ( 
	systemUnitClassLib As SystemUnitClassLibType,
	systemUnitClassName As String
) As SystemUnitFamilyType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static SystemUnitFamilyType^ New_SystemUnitClass(
	SystemUnitClassLibType^ systemUnitClassLib, 
	String^ systemUnitClassName
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClassLib</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassLibType">Aml.Engine.CAEX.SystemUnitClassLibType</a><br />The SystemUnitClassLib object</dd><dt>systemUnitClassName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the SystemUnitClass element.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a><br />A new SystemUnitClass

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitClassLibType">SystemUnitClassLibType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassLibTypeExtensions">SystemUnitClassLibTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />