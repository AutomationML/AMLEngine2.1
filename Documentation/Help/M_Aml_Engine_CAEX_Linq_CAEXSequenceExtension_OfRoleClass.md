# CAEXSequenceExtension.OfRoleClass Method (CAEXSequence(RoleRequirementsType), RoleFamilyType)
AutomationML 2.1 API 

Gets all RoleRequirements from the specified sequence, which are instances of a specific RoleClass

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Linq">Aml.Engine.CAEX.Linq</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<RoleRequirementsType> OfRoleClass(
	this CAEXSequence<RoleRequirementsType> sequence,
	RoleFamilyType roleClass
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function OfRoleClass ( 
	sequence As CAEXSequence(Of RoleRequirementsType),
	roleClass As RoleFamilyType
) As IEnumerable(Of RoleRequirementsType)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static IEnumerable<RoleRequirementsType^>^ OfRoleClass(
	CAEXSequence<RoleRequirementsType^>^ sequence, 
	RoleFamilyType^ roleClass
)
```


#### Parameters
&nbsp;<dl><dt>sequence</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXSequence_1">Aml.Engine.CAEX.CAEXSequence</a>(<a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType</a>)<br />The Sequence of Role Requirements</dd><dt>roleClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">Aml.Engine.CAEX.RoleFamilyType</a><br />The required Role Class</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType</a>)<br />RoleRequirements which are instances of the defined class.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence</a>(<a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType</a>). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Linq_CAEXSequenceExtension">CAEXSequenceExtension Class</a><br /><a href="Overload_Aml_Engine_CAEX_Linq_CAEXSequenceExtension_OfRoleClass">OfRoleClass Overload</a><br /><a href="N_Aml_Engine_CAEX_Linq">Aml.Engine.CAEX.Linq Namespace</a><br />