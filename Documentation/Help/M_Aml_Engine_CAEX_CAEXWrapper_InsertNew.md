# CAEXWrapper.InsertNew Method 
AutomationML 2.1 API 

This method can be used to create an XML node, if this CAEX wrapper was instantiated without an XML node. This method can only be applied, if an <a href="P_Aml_Engine_CAEX_CAEXWrapper_Owner">Owner</a> is defined. The new created CAEX object is inserted as a new child of the owner.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public bool InsertNew()
```

**VB**<br />
``` VB
Public Function InsertNew As Boolean
```

**C++**<br />
``` C++
public:
bool InsertNew()
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true, if the XML node could be created and inserted as a new child of the owner.`

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXWrapper">CAEXWrapper Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />