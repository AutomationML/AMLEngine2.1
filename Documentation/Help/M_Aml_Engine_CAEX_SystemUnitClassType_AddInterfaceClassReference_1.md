# SystemUnitClassType.AddInterfaceClassReference Method (String, Boolean, Boolean, String)
AutomationML 2.1 API 

Adds an InterfaceClass reference to this SystemUnitClass object using the provided CAEX path, referencing an InterfaceClass object. The InterfaceClass reference is added as a <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a> object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ExternalInterfaceType AddInterfaceClassReference(
	string interfaceClassReference,
	bool addUnique = true,
	bool addInstance = false,
	string name = ""
)
```

**VB**<br />
``` VB
Public Function AddInterfaceClassReference ( 
	interfaceClassReference As String,
	Optional addUnique As Boolean = true,
	Optional addInstance As Boolean = false,
	Optional name As String = ""
) As ExternalInterfaceType
```

**C++**<br />
``` C++
public:
ExternalInterfaceType^ AddInterfaceClassReference(
	String^ interfaceClassReference, 
	bool addUnique = true, 
	bool addInstance = false, 
	String^ name = L""
)
```


#### Parameters
&nbsp;<dl><dt>interfaceClassReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The CAEX path referencing a InterfaceClass to be assigned to the SystemUnitClass.</dd><dt>addUnique (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` the reference is not added, if the same reference already exists.</dd><dt>addInstance (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true`, the reference is created as an instance of the InterfaceClass, identified by the provided interfaceClassReference, containig all ExternalInterfaces and Attributes of the InterfaceClass.</dd><dt>name (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Provides the name for the new external interface.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType</a><br />The new added InterfaceClass reference.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>interfaceClassReference</td></tr></table>

## Remarks
The default behaviour is, that only a reference to the interface class is added and no instance of the class containing all Attributes and ExternalInterface objects. If an instance is required, set the optional parameter 'addInstance' to true or use the <a href="M_Aml_Engine_CAEX_InterfaceFamilyType_CreateClassInstance">CreateClassInstance()</a> and the <a href="M_Aml_Engine_CAEX_SystemUnitClassType_Insert">Insert(CAEXWrapper, Boolean)</a> methods,

## Examples
This sample shows how to call the AddInterfaceClassReference(String, Boolean, Boolean, String) method using a standard InterfaceClass path defined in the <a href="T_Aml_Engine_AmlObjects_AutomationMLInterfaceClassLib">AutomationMLInterfaceClassLib</a>
```
var myIH = myDocument.CAEXFile.InstanceHierarchy.Append ("myIH");
var myIE = myIH.InternalElement.Append("myIH");
myIE.AddInterfaceClassReference (AutomationMLInterfaceClassLib.AutomationMLBaseInterface);
```


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType Class</a><br /><a href="Overload_Aml_Engine_CAEX_SystemUnitClassType_AddInterfaceClassReference">AddInterfaceClassReference Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />