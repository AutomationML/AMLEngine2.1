# ExternalInterfaceType.Remove Method 
AutomationML 2.1 API 

Removes this ExternalInterface. After that it is no longer assigned to a document and has no owner anymore. If this ExternalInterfaces has InternalLink relations, the InternalLink relations are removed too.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override void Remove(
	bool removeRelations = true
)
```

**VB**<br />
``` VB
Public Overrides Sub Remove ( 
	Optional removeRelations As Boolean = true
)
```

**C++**<br />
``` C++
public:
virtual void Remove(
	bool removeRelations = true
) override
```


#### Parameters
&nbsp;<dl><dt>removeRelations (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />\[Missing <param name="removeRelations"/> documentation for "M:Aml.Engine.CAEX.ExternalInterfaceType.Remove(System.Boolean)"\]</dd></dl>

#### Implements
<a href="M_Aml_Engine_CAEX_ICAEXWrapper_Remove">ICAEXWrapper.Remove(Boolean)</a><br /><a href="M_Aml_Engine_CAEX_ICAEXWrapper_Remove">ICAEXWrapper.Remove(Boolean)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ExternalInterfaceType">ExternalInterfaceType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />