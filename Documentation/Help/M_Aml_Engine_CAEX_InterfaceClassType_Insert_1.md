# InterfaceClassType.Insert Method (Int32, CAEXWrapper)
AutomationML 2.1 API 

Inserts the specified CAEX object in it's associated sequence at the given position. The InterfaceClass defines the <a href="P_Aml_Engine_CAEX_InterfaceClassType_Attribute">Attribute</a> and <a href="P_Aml_Engine_CAEX_InterfaceClassType_ExternalInterface">ExternalInterface</a> sequence.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override bool Insert(
	int pos,
	CAEXWrapper caexObject
)
```

**VB**<br />
``` VB
Public Overrides Function Insert ( 
	pos As Integer,
	caexObject As CAEXWrapper
) As Boolean
```

**C++**<br />
``` C++
public:
virtual bool Insert(
	int pos, 
	CAEXWrapper^ caexObject
) override
```


#### Parameters
&nbsp;<dl><dt>pos</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.int32" target="_parent" rel="noopener noreferrer">System.Int32</a><br /></dd><dt>caexObject</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper">Aml.Engine.CAEX.CAEXWrapper</a><br />The CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">Boolean</a><br />`true`, if a sequence could be identified and the provided CAEX object is inserted; If a copy of the CAEX object has been inserted or the provided CAEX object doesn't represent a valid member of any sequence the result is `false`.

#### Implements
<a href="M_Aml_Engine_CAEX_ICAEXBasicObject_Insert_1">ICAEXBasicObject.Insert(Int32, CAEXWrapper)</a><br />

## Remarks
If the provided CAEX object already has an associated parent, a copy of the CAEX object and not the original provided CAEX Object is inserted. Please keep in mind, that the copied object contains identical attributes and elements. It might not represent a valid AutomationML object, because IDs and references are not automatically modified.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InterfaceClassType">InterfaceClassType Class</a><br /><a href="Overload_Aml_Engine_CAEX_InterfaceClassType_Insert">Insert Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />