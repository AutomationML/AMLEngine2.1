# ExternalDataReference.ExternalDataRoleClass Method (RoleClassLibType)
AutomationML 2.1 API 

Gets the 'ExternalData' RoleClass from the AutomationMLBPRRoleClassLib.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static RoleFamilyType ExternalDataRoleClass(
	this RoleClassLibType automationMLBPRRoleClassLib
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function ExternalDataRoleClass ( 
	automationMLBPRRoleClassLib As RoleClassLibType
) As RoleFamilyType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static RoleFamilyType^ ExternalDataRoleClass(
	RoleClassLibType^ automationMLBPRRoleClassLib
)
```


#### Parameters
&nbsp;<dl><dt>automationMLBPRRoleClassLib</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleClassLibType">Aml.Engine.CAEX.RoleClassLibType</a><br />The AutomationMLBPRRoleClassLib.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">RoleFamilyType</a><br />The ExternalData RoleClass.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_RoleClassLibType">RoleClassLibType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.nullreferenceexception" target="_parent" rel="noopener noreferrer">NullReferenceException</a></td><td>Couldn't locate the ExternalData role class</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_ExternalDataReference">ExternalDataReference Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClass">ExternalDataRoleClass Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />