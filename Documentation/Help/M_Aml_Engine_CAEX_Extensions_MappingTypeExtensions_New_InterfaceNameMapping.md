# MappingTypeExtensions.New_InterfaceNameMapping Method 
AutomationML 2.1 API 

Adding a new InterfaceNameMapping to the defined Mapping object. An InterfaceNameMapping allows the definition of the mapping between Interface names of corresponding RoleClasses and SystemUnitClasses.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static InterfaceNameMappingType New_InterfaceNameMapping(
	this MappingType mappingObject,
	string systemUnitInterfaceName,
	string roleInterfaceName
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_InterfaceNameMapping ( 
	mappingObject As MappingType,
	systemUnitInterfaceName As String,
	roleInterfaceName As String
) As InterfaceNameMappingType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static InterfaceNameMappingType^ New_InterfaceNameMapping(
	MappingType^ mappingObject, 
	String^ systemUnitInterfaceName, 
	String^ roleInterfaceName
)
```


#### Parameters
&nbsp;<dl><dt>mappingObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_MappingType">Aml.Engine.CAEX.MappingType</a><br />The Mapping object</dd><dt>systemUnitInterfaceName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name of the interface in the SystemUnitClass</dd><dt>roleInterfaceName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The name of the interface in the RoleClass</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InterfaceNameMappingType">InterfaceNameMappingType</a><br />The new InterfaceNameMapping element

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_MappingType">MappingType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Remarks
Use of this method is restricted to CAEX Version 2.15.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_MappingTypeExtensions">MappingTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />