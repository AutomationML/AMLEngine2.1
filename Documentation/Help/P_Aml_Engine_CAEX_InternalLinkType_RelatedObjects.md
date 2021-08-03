# InternalLinkType.RelatedObjects Property 
AutomationML 2.1 API 

Gets the related objects for the InternalLink. This property allows to access the listed related objects without recalculation.
&nbsp;<ul><li><a href="P_Aml_Engine_CAEX_InternalLinkType_AInterface">AInterface</a></li><li><a href="P_Aml_Engine_CAEX_InternalLinkType_BInterface">BInterface</a></li><li><a href="P_Aml_Engine_CAEX_InternalLinkType_ASystemUnitClass">ASystemUnitClass</a></li><li><a href="P_Aml_Engine_CAEX_InternalLinkType_BSystemUnitClass">BSystemUnitClass</a></li></ul>&nbsp;
A direct access to one of the listed properties results in a recalculation of the accessed property.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public InternalLinkType.LinkedObjects RelatedObjects { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property RelatedObjects As InternalLinkType.LinkedObjects
	Get
```

**C++**<br />
``` C++
public:
property InternalLinkType.LinkedObjects^ RelatedObjects {
	InternalLinkType.LinkedObjects^ get ();
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_InternalLinkType_LinkedObjects">InternalLinkType.LinkedObjects</a><br />The related objects.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalLinkType">InternalLinkType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />