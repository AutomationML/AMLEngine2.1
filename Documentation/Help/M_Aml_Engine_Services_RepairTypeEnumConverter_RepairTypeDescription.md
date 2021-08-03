# RepairTypeEnumConverter.RepairTypeDescription Method 
AutomationML 2.1 API 

Converts the specified repair option to a readable string

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static string RepairTypeDescription(
	this RepairTypeEnum repairOption
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function RepairTypeDescription ( 
	repairOption As RepairTypeEnum
) As String
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static String^ RepairTypeDescription(
	RepairTypeEnum repairOption
)
```


#### Parameters
&nbsp;<dl><dt>repairOption</dt><dd>Type: <a href="T_Aml_Engine_Services_RepairTypeEnum">Aml.Engine.Services.RepairTypeEnum</a><br />Option for repairing an element.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />a readable string describing the repair option

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_Services_RepairTypeEnum">RepairTypeEnum</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_RepairTypeEnumConverter">RepairTypeEnumConverter Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />