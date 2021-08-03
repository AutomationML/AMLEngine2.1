# MappingTypeExtensions.Insert_InterfaceNameMapping Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Appends the InterfaceNameMapping object to the defined Mapping object

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use mappingObject.Insert instead")]
public static void Insert_InterfaceNameMapping(
	this MappingType mappingObject,
	InterfaceNameMappingType interfaceNameMapping
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use mappingObject.Insert instead")>
Public Shared Sub Insert_InterfaceNameMapping ( 
	mappingObject As MappingType,
	interfaceNameMapping As InterfaceNameMappingType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use mappingObject.Insert instead")]
static void Insert_InterfaceNameMapping(
	MappingType^ mappingObject, 
	InterfaceNameMappingType^ interfaceNameMapping
)
```


#### Parameters
&nbsp;<dl><dt>mappingObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_MappingType">Aml.Engine.CAEX.MappingType</a><br />The Mapping object</dd><dt>interfaceNameMapping</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InterfaceNameMappingType">Aml.Engine.CAEX.InterfaceNameMappingType</a><br />The interface name mapping.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_MappingType">MappingType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Remarks
Use of this method is restricted to CAEX Version 2.15.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_MappingTypeExtensions">MappingTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />