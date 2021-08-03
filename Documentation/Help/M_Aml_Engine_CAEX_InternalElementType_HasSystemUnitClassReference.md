# InternalElementType.HasSystemUnitClassReference Method 
AutomationML 2.1 API 

Determines whether this InternalElement object has an associated reference to the specified SystemUnitClass. If inheritance relations between systemUnitClasses should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified SystemUnitClass is either identical to a referenced SystemUnitClass or a referenced SystemUnitClass is derived from the specified SystemUnitClass.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool HasSystemUnitClassReference(
	SystemUnitFamilyType systemUnitClass,
	bool regardInheritance = false
)
```

**VB**<br />
``` VB
Public Function HasSystemUnitClassReference ( 
	systemUnitClass As SystemUnitFamilyType,
	Optional regardInheritance As Boolean = false
) As Boolean
```

**C++**<br />
``` C++
public:
bool HasSystemUnitClassReference(
	SystemUnitFamilyType^ systemUnitClass, 
	bool regardInheritance = false
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClass</dt><dd>Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">Aml.Engine.CAEX.SystemUnitFamilyType</a><br />The SystemUnitClass object.</dd><dt>regardInheritance (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` inheritance relations are regarded (default is `false`).</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true` if this InternalElement object has an associated reference to the specified SystemUnitClass; otherwise, `false`.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>roleClass</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />