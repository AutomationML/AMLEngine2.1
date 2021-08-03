# AttributeType.AttributeTreeOwner Property 
AutomationML 2.1 API 

Gets the owner of the Attribute Tree. This is the first ancestor, which is not an AttributeType object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IObjectWithAttributes AttributeTreeOwner { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property AttributeTreeOwner As IObjectWithAttributes
	Get
```

**C++**<br />
``` C++
public:
property IObjectWithAttributes^ AttributeTreeOwner {
	IObjectWithAttributes^ get ();
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_IObjectWithAttributes">IObjectWithAttributes</a><br />The TreeOwner

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_AttributeType">AttributeType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />