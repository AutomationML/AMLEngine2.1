# AMLEngineAdapter.AssignNewGUIDsAndRedirectExistingInternalLinksAndMirrorObjects Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

This Method assigns new GUIds to the SystemUnitClass and its subordinate Children, which have an ID. The References to the old IDs in Mirrors and InternalLinks are redirected to the new ID. If a Reference is not found in any of the subordinate Elements, the Reference will not be changed.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Make a copy instead and replace the existing class using the copy", 
	true)]
public static void AssignNewGUIDsAndRedirectExistingInternalLinksAndMirrorObjects(
	this SystemUnitClassType systemUnitClass,
	bool includeSystemUnitClasses = false
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Make a copy instead and replace the existing class using the copy", 
	true)>
Public Shared Sub AssignNewGUIDsAndRedirectExistingInternalLinksAndMirrorObjects ( 
	systemUnitClass As SystemUnitClassType,
	Optional includeSystemUnitClasses As Boolean = false
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Make a copy instead and replace the existing class using the copy", 
	true)]
static void AssignNewGUIDsAndRedirectExistingInternalLinksAndMirrorObjects(
	SystemUnitClassType^ systemUnitClass, 
	bool includeSystemUnitClasses = false
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />The system unit class.</dd><dt>includeSystemUnitClasses (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` [include system unit classes].</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## Remarks
If you want an assignment of new GUIDs with updated references, make a copy of the SystemUnitClass and replace the old class with the new class.

## See Also


#### Reference
<a href="T_Aml_Engine_Adapter_AMLEngineAdapter">AMLEngineAdapter Class</a><br /><a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter Namespace</a><br />