# CAEXWrapper(*TDataType*).Value Property 
AutomationML 2.1 API 

Gets and sets the value of the wrapped XML node, according to the defined DataType. If the element doesn't exists, it is created and inserted into the document as a child of the defined owner.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public TDataType Value { get; set; }
```

**VB**<br />
``` VB
Public Property Value As TDataType
	Get
	Set
```

**C++**<br />
``` C++
public:
property TDataType Value {
	TDataType get ();
	void set (TDataType value);
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_CAEXWrapper_1">*TDataType*</a><br />The value.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXWrapper_1">CAEXWrapper(TDataType) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />