# SystemUnitClassType.Insert Method (CAEXWrapper, Boolean)
AutomationML 2.1 API 

Inserts the specified CAEX object in it's associated sequence. The SystemUnitClass defines the <a href="P_Aml_Engine_CAEX_SystemUnitClassType_Attribute">Attribute</a>, <a href="P_Aml_Engine_CAEX_SystemUnitClassType_ExternalInterface">ExternalInterface</a>, <a href="P_Aml_Engine_CAEX_SystemUnitClassType_InternalElement">InternalElement</a>, <a href="P_Aml_Engine_CAEX_SystemUnitClassType_InternalLink">InternalLink</a>, and <a href="P_Aml_Engine_CAEX_SystemUnitClassType_SupportedRoleClass">SupportedRoleClass</a> sequence.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override bool Insert(
	CAEXWrapper caexObject,
	bool asFirst = true
)
```

**VB**<br />
``` VB
Public Overrides Function Insert ( 
	caexObject As CAEXWrapper,
	Optional asFirst As Boolean = true
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool Insert(
	CAEXWrapper^ caexObject, 
	bool asFirst = true
) override
```


#### Parameters
&nbsp;<dl><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">Aml.Engine.CAEX.CAEXWrapper</a><br />The CAEX object.</dd><dt>asFirst (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />if set to `true` it is inserted as the first item in its associated sequence.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`.

#### Implements
<a href="M_Aml_Engine_CAEX_ICAEXBasicObject_Insert">ICAEXBasicObject.Insert(CAEXWrapper, Boolean)</a><br /><a href="M_Aml_Engine_CAEX_ICAEXContainer_Insert">ICAEXContainer.Insert(CAEXWrapper, Boolean)</a><br /><a href="M_Aml_Engine_CAEX_ICAEXBasicObject_Insert">ICAEXBasicObject.Insert(CAEXWrapper, Boolean)</a><br />

## Remarks
If the provided CAEX object already has an associated parent, a copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitClassType">SystemUnitClassType Class</a><br /><a href="Overload_Aml_Engine_CAEX_SystemUnitClassType_Insert">Insert Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />