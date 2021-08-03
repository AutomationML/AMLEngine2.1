# AMLGroupInternalElementSequence.Insert Method 
AutomationML 2.1 API 

Inserts the specified InternalElement into this sequence. Before the InternalElement is inserted, it is checked, if it is a valid Group-InternalElement.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override InternalElementType Insert(
	InternalElementType internalElement,
	bool asFirst = true
)
```

**VB**<br />
``` VB
Public Overrides Function Insert ( 
	internalElement As InternalElementType,
	Optional asFirst As Boolean = true
) As InternalElementType
```

**C++**<br />
``` C++
public:
virtual InternalElementType^ Insert(
	InternalElementType^ internalElement, 
	bool asFirst = true
) override
```


#### Parameters
&nbsp;<dl><dt>internalElement</dt><dd>Type: <a href="T_Aml_Engine_CAEX_InternalElementType">Aml.Engine.CAEX.InternalElementType</a><br />The InternalElement.</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />optional parameter, if set to `true (default)` the element is prepended to already existing ones, otherwise it is appended.</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a><br />\[Missing <returns> documentation for "M:Aml.Engine.AmlObjects.AMLGroupInternalElementSequence.Insert(Aml.Engine.CAEX.InternalElementType,System.Boolean)"\]

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLGroupInternalElementSequence">AMLGroupInternalElementSequence Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />