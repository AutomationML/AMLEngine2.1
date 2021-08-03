# InternalElementType.AddRoleClassReference Method (RoleFamilyType, Boolean, Boolean, Boolean)
AutomationML 2.1 API 

Adds a RoleClass reference to this InternalElement object using the provided RoleClass object. The RoleClass reference is added as a <a href="T_Aml_Engine_CAEX_RoleRequirementsType">RoleRequirementsType</a> object. For CAEX documents which are based on CAEX version 2.15, only one RoleRequirement is allowed for an InternalElement. Additional RoleClass references are automatically added as SupportedRoleClass objects.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IObjectWithRoleReference AddRoleClassReference(
	RoleFamilyType roleClass,
	bool addSupportedRoleClass = false,
	bool addUnique = true,
	bool addInstance = false
)
```

**VB**<br />
``` VB
Public Function AddRoleClassReference ( 
	roleClass As RoleFamilyType,
	Optional addSupportedRoleClass As Boolean = false,
	Optional addUnique As Boolean = true,
	Optional addInstance As Boolean = false
) As IObjectWithRoleReference
```

**C++**<br />
``` C++
public:
IObjectWithRoleReference^ AddRoleClassReference(
	RoleFamilyType^ roleClass, 
	bool addSupportedRoleClass = false, 
	bool addUnique = true, 
	bool addInstance = false
)
```


#### Parameters
&nbsp;<dl><dt>roleClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_RoleFamilyType">Aml.Engine.CAEX.RoleFamilyType</a><br />The RoleClass to be assigned to the InternalElement.</dd><dt>addSupportedRoleClass (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` [add supported role class].</dd><dt>addUnique (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true`, the RoleClass reference is not added, if a reference to the provided RoleClass already exists.</dd><dt>addInstance (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true`, the reference is created as am instance of the RoleClass, containig all ExternalInterfaces and Attributes of the RoleClass.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_IObjectWithRoleReference">IObjectWithRoleReference</a><br />The new added RoleClass reference, which is either a RoleRequirement or a SupportedRoleClass.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleClass</td></tr></table>

## Remarks
The default behaviour is, that only a reference to the role class is added and no instance of the class containing all Attributes and ExternalInterface objects. If an instance is required, set the optional parameter 'addInstance' to true or use the <a href="M_Aml_Engine_CAEX_RoleFamilyType_CreateClassInstance">CreateClassInstance()</a> and the <a href="M_Aml_Engine_CAEX_InternalElementType_Insert">Insert(CAEXWrapper, Boolean)</a> methods.

## Examples
This sample shows how to call the AddRoleClassReference(RoleFamilyType, Boolean, Boolean, Boolean) method using a standard base RoleClass from the <a href="M_Aml_Engine_AmlObjects_AutomationMLBaseRoleClassLibType_RoleClassLib">RoleClassLib(CAEXDocument)</a>
```
var amlBaseRoleClassLib = AutomationMLBaseRoleClassLibType.RoleClassLib (myDocument);
var myIH = myDocument.CAEXFile.InstanceHierarchy.Append ("myIH");
var myIE = myIH.InternalElement.Append("myIH");
myIE.AddRoleClassReference (amlBaseRoleClassLib.AutomationMLBaseRole);
```


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType Class</a><br /><a href="Overload_Aml_Engine_CAEX_InternalElementType_AddRoleClassReference">AddRoleClassReference Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />