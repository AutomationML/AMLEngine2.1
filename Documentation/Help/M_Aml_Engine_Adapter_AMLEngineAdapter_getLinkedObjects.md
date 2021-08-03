# AMLEngineAdapter.getLinkedObjects Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Getting a List of LinkedObjects object of this SystemUnitClass containing references to the concrete referenced InternalElements via an InternalLink.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Direct enumeration of the InternalLink property is supported", 
	false)]
public static List<LinkedObjects> getLinkedObjects(
	this SystemUnitClassType systemUnitClass
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Direct enumeration of the InternalLink property is supported", 
	false)>
Public Shared Function getLinkedObjects ( 
	systemUnitClass As SystemUnitClassType
) As List(Of LinkedObjects)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Direct enumeration of the InternalLink property is supported", 
	false)]
static List<LinkedObjects^>^ getLinkedObjects(
	SystemUnitClassType^ systemUnitClass
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />The system unit class.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.list-1" target="_parent" rel="noopener noreferrer">List</a>(<a href="T_Aml_Engine_Adapter_LinkedObjects">LinkedObjects</a>)<br />A list of linkedObjects for this SystemUnitClass. This list is empty if no InternalLink exists

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />