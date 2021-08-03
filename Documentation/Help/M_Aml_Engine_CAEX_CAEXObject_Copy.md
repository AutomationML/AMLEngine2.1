# CAEXObject.Copy Method 
AutomationML 2.1 API 

Creates a deep copy of this CAEX object, containing all child elements. The created copy will have replaced unique IDs and updated references, if the *assignNewIDs* is set to true (default). When a CAEX class is copied, the nested classes that can exist for AttributeType, RoleClass, SystemUnitClass, and InterfaceClass are not included in the created copy.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override CAEXWrapper Copy(
	bool deepCopy = true,
	bool assignNewIDs = true,
	bool includeSubClasses = false
)
```

**VB**<br />
``` VB
Public Overrides Function Copy ( 
	Optional deepCopy As Boolean = true,
	Optional assignNewIDs As Boolean = true,
	Optional includeSubClasses As Boolean = false
) As CAEXWrapper
```

**C++**<br />
``` C++
public:
virtual CAEXWrapper^ Copy(
	bool deepCopy = true, 
	bool assignNewIDs = true, 
	bool includeSubClasses = false
) override
```


#### Parameters
&nbsp;<dl><dt>deepCopy (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` a deep copy is created; otherwise only the attributes are included in the copy. The default value is `true`.</dd><dt>assignNewIDs (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` all elements with IDs get unique IDs and the ID references will be updated. The default value is `true`.</dd><dt>includeSubClasses (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` sub classes of SystemUnitClasses, InterfacesClasses, RoleClasses and AttributeTypes are included in the copy. The default value is `false`.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper</a><br />A copy of this CAEX object with unique IDs.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />