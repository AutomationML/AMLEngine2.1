# CAEXPathBuilder.IsInterfaceReference Method 
AutomationML 2.1 API 

Determines, if the path is build using an interface separator. This method is able to distinguish if an interface separator char is used in an interface name and is escaped

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static bool IsInterfaceReference(
	string classReference
)
```

**VB**<br />
``` VB
Public Shared Function IsInterfaceReference ( 
	classReference As String
) As Boolean
```

**C++**<br />
``` C++
public:
static bool IsInterfaceReference(
	String^ classReference
)
```


#### Parameters
&nbsp;<dl><dt>classReference</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The class reference.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if the provided class reference is an interface reference.

## Remarks
This method should only be used for CAEXDocuments based on CAEX Version 2.15

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />