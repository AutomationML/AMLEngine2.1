# SystemUnitFamilyType.GetReferencedSystemUnitClass Method 
AutomationML 2.1 API 

Getting a referenced SystemUnitClass.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public SystemUnitFamilyType GetReferencedSystemUnitClass(
	string systemUnitClassReference
)
```

**VB**<br />
``` VB
Public Function GetReferencedSystemUnitClass ( 
	systemUnitClassReference As String
) As SystemUnitFamilyType
```

**C++**<br />
``` C++
public:
SystemUnitFamilyType^ GetReferencedSystemUnitClass(
	String^ systemUnitClassReference
)
```


#### Parameters
&nbsp;<dl><dt>systemUnitClassReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Full path to a SystemUnitClass</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType</a><br />The referenced SystemUnitClass

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentnullexception" target="_parent" rel="noopener noreferrer">ArgumentNullException</a></td><td>systemUnitClassReference</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />