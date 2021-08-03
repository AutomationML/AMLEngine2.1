# SystemUnitClassType.HasInterfaceClassReference Method 
AutomationML 2.1 API 

Determines whether this CAEX Element has an associated reference to the specified InterfaceClass. If inheritance relations between InterfaceClasses should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified InterfaceClass is either identical to a referenced InterfaceClass or a referenced InterfaceClass is derived from the specified InterfaceClass.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool HasInterfaceClassReference(
	InterfaceFamilyType interfaceClass,
	bool regardInheritance = false
)
```

**VB**<br />
``` VB
Public Function HasInterfaceClassReference ( 
	interfaceClass As InterfaceFamilyType,
	Optional regardInheritance As Boolean = false
) As Boolean
```

**C++**<br />
``` C++
public:
bool HasInterfaceClassReference(
	InterfaceFamilyType^ interfaceClass, 
	bool regardInheritance = false
)
```


#### Parameters
&nbsp;<dl><dt>interfaceClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InterfaceFamilyType">Aml.Engine.CAEX.InterfaceFamilyType</a><br />The InterfaceClass object.</dd><dt>regardInheritance (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` inheritance relations are regarded (default is `false`).</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this CAEX Element object has an associated reference to the specified InterfaceClass; otherwise, `false`.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleClass</td></tr></table>

## Examples
This sample shows how to call the HasInterfaceClassReference(InterfaceFamilyType, Boolean) method using a standard base InterfaceClass from the <a href="M_Aml_Engine_AmlObjects_AutomationMLInterfaceClassLibType_InterfaceClassLib">InterfaceClassLib(CAEXDocument)</a>
```
var amlInterfaceClassLib = AutomationMLInterfaceClassLibType.InterfaceClassLib (myDocument);
InternalElementType internalElement;
...
internalElement.HasInterfaceClassReference (amlInterfaceClassLib.COLLADAInterface);
```


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />