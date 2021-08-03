# InternalElementType.New_MappingObject Method 
AutomationML 2.1 API 

Adding a new MappingObject element to this InternalElement.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public MappingType New_MappingObject()
```

**VB**<br />
``` VB
Public Function New_MappingObject As MappingType
```

**C++**<br />
``` C++
public:
MappingType^ New_MappingObject()
```


#### Return Value
Type: <a href="T_Aml_Engine_CAEX_MappingType">MappingType</a><br />The new MappingObject element if not existing, otherwise the existing.

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.nullreferenceexception" target="_parent" rel="noopener noreferrer">NullReferenceException</a></td><td>An InternalElement object doesn't exist!</td></tr><tr><td><a href="T_Aml_Engine_CAEX_SchemaConformanceException">SchemaConformanceException</a></td><td>Raised if applied to CAEX 3.0 and later versions.</td></tr></table>

## Remarks
Only valid for CAEX 2.15. Don't use this method for later versions of CAEX. If used for later versions, a SchemaConformanceException is raised.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />