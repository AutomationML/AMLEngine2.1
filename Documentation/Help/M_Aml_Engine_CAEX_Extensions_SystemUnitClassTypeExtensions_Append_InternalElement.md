# SystemUnitClassTypeExtensions.Append_InternalElement Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Inserts the InternalElement object after the defined Predecessor in the InternalElement collection of the SystemUnitClass. If the Predecessor is null, the InternalElement object is inserted at the first position of the InternalElement collection.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use internalElementPredecessor.InsertAfter()")]
public static void Append_InternalElement(
	this SystemUnitClassType systemUnitClass,
	InternalElementType internalElement,
	InternalElementType internalElementPredecessor
)
```

**VB**<br />
``` VB
<ExtensionAttribute>
<ObsoleteAttribute("Use internalElementPredecessor.InsertAfter()")>
Public Shared Sub Append_InternalElement ( 
	systemUnitClass As SystemUnitClassType,
	internalElement As InternalElementType,
	internalElementPredecessor As InternalElementType
)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
[ObsoleteAttribute(L"Use internalElementPredecessor.InsertAfter()")]
static void Append_InternalElement(
	SystemUnitClassType^ systemUnitClass, 
	InternalElementType^ internalElement, 
	InternalElementType^ internalElementPredecessor
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitClassType">Aml.Engine.CAEX.SystemUnitClassType</a><br />The SystemUnitClass object</dd><dt>internalElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The internal element.</dd><dt>internalElementPredecessor</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The internal element predecessor.</dd></dl>

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType</a>. When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions">SystemUnitClassTypeExtensions Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />