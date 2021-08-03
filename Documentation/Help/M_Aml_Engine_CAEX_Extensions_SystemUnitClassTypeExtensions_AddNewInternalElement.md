# SystemUnitClassTypeExtensions.AddNewInternalElement Method 
AutomationML 2.1 API 

Creates a new InternalElement and inserts it after the last InternalElement of the parent if the elementName is unique among the child's. The ChangeMode is set to the Value 'Create'

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static InternalElementType AddNewInternalElement(
	this SystemUnitClassType systemUnitClass,
	string elementName
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function AddNewInternalElement ( 
	systemUnitClass As SystemUnitClassType,
	elementName As String
) As InternalElementType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static InternalElementType^ AddNewInternalElement(
	SystemUnitClassType^ systemUnitClass, 
	String^ elementName
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />Parent of the new InternalElement</dd><dt>elementName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the new InternalElement</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a><br />the new InternalElement or null, if the elementName is not unique

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />