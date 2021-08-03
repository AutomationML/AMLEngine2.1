# MappingTypeExtensions.New_AttributeNameMapping Method 
AutomationML 2.1 API 

Adding a new AttributeNameMapping to the defined Mapping object. An AttributeNameMapping allows the definition of the mapping between attribute names of corresponding RoleClasses and SystemUnitClasses.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static AttributeNameMappingType New_AttributeNameMapping(
	this MappingType mappingObject,
	string systemUnitAttributeName,
	string roleAttributeName
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function New_AttributeNameMapping ( 
	mappingObject As MappingType,
	systemUnitAttributeName As String,
	roleAttributeName As String
) As AttributeNameMappingType
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
static AttributeNameMappingType^ New_AttributeNameMapping(
	MappingType^ mappingObject, 
	String^ systemUnitAttributeName, 
	String^ roleAttributeName
)
```


#### Parameters
&nbsp;<dl><dt>mappingObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_MappingType">Aml.Engine.CAEX.MappingType</a><br />The Mapping object</dd><dt>systemUnitAttributeName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The attribute name of the SystemUnitClass</dd><dt>roleAttributeName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The attribute name of the RoleClass</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_AttributeNameMappingType">AttributeNameMappingType</a><br />The new AttributeNameMapping element

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_MappingType">MappingType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_MappingTypeExtensions">MappingTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />