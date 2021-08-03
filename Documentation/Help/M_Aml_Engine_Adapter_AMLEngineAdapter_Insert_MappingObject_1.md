# AMLEngineAdapter.Insert_MappingObject Method (SupportedRoleClassType, MappingType)
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Adding a MappingObject element to this Supported Role.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use Insert Method instead", false)]
public static void Insert_MappingObject(
	this SupportedRoleClassType supportedRoleClass,
	MappingType mappingObject
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use Insert Method instead", false)>
Public Shared Sub Insert_MappingObject ( 
	supportedRoleClass As SupportedRoleClassType,
	mappingObject As MappingType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use Insert Method instead", false)]
static void Insert_MappingObject(
	SupportedRoleClassType^ supportedRoleClass, 
	MappingType^ mappingObject
)
```


#### Parameters
&nbsp;<dl><dt>supportedRoleClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SupportedRoleClassType">Aml.Engine.CAEX.SupportedRoleClassType</a><br />The supported role element.</dd><dt>mappingObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_MappingType">Aml.Engine.CAEX.MappingType</a><br />The mapping object.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SupportedRoleClassType">SupportedRoleClassType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="Overload_Aml_Engine_Adapter_AMLEngineAdapter_Insert_MappingObject">Insert_MappingObject Overload</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />