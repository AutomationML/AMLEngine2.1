# SystemUnitFamilyTypeExtensions.New_SystemUnitClass Method 
AutomationML 2.1 API 

Adding a new SystemUnitClass to this SystemUnitFamily.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static SystemUnitFamilyType New_SystemUnitClass(
	this SystemUnitFamilyType systemUnitFamilyType,
	string systemUnitClassName
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_SystemUnitClass ( 
	systemUnitFamilyType As SystemUnitFamilyType,
	systemUnitClassName As String
) As SystemUnitFamilyType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static SystemUnitFamilyType^ New_SystemUnitClass(
	SystemUnitFamilyType^ systemUnitFamilyType, 
	String^ systemUnitClassName
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitFamilyType</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">Aml.Engine.CAEX.SystemUnitFamilyType</a><br />The SystemUnitFamily object</dd><dt>systemUnitClassName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the SystemUnitClass element.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a><br />A new SystemUnitClass

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitFamilyTypeExtensions">SystemUnitFamilyTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />