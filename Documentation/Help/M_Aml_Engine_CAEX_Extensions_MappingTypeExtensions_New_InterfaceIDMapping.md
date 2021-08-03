# MappingTypeExtensions.New_InterfaceIDMapping Method (MappingType, ExternalInterfaceType, ExternalInterfaceType)
AutomationML 2.1 API 

Adding a new InterfaceIDMapping to the defined Mapping object. An InterfaceIDMapping allows the definition of the mapping between Interfaces of corresponding RoleClasses and SystemUnitClasses.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static InterfaceIDMappingType New_InterfaceIDMapping(
	this MappingType mappingObject,
	ExternalInterfaceType systemUnitInterface,
	ExternalInterfaceType roleInterface
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_InterfaceIDMapping ( 
	mappingObject As MappingType,
	systemUnitInterface As ExternalInterfaceType,
	roleInterface As ExternalInterfaceType
) As InterfaceIDMappingType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static InterfaceIDMappingType^ New_InterfaceIDMapping(
	MappingType^ mappingObject, 
	ExternalInterfaceType^ systemUnitInterface, 
	ExternalInterfaceType^ roleInterface
)
```


#### Parameters
&nbsp;<dl><dt>mappingObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_MappingType">Aml.Engine.CAEX.MappingType</a><br />The Mapping object</dd><dt>systemUnitInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The interface in the SystemUnitClass</dd><dt>roleInterface</dt><dd>Type: <a href="T_Aml_Engine_CAEX_ExternalInterfaceType">Aml.Engine.CAEX.ExternalInterfaceType</a><br />The interface in the RoleClass</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InterfaceIDMappingType">InterfaceIDMappingType</a><br />The new InterfaceIDMapping element

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_MappingType">MappingType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Remarks
Use of this method is restricted to CAEX Version 3.0 and above.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_MappingTypeExtensions">MappingTypeExtensions Class</a><br /><a href="Overload_Aml_Engine_CAEX_Extensions_MappingTypeExtensions_New_InterfaceIDMapping">New_InterfaceIDMapping Overload</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />