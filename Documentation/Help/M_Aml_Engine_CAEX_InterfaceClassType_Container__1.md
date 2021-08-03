# InterfaceClassType.Container(*T*) Method 
AutomationML 2.1 API 

Gets the CAEX Container for elements of type T, which is owned by this CAEX object

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override CAEXSequence<T> Container<T>()
where T : CAEXWrapper

```

**VB**<br />
``` VB
Public Overrides Function Container(Of T As CAEXWrapper) As CAEXSequence(Of T)
```

**C++**<br />
``` C++
public:
generic<typename T>
where T : CAEXWrapper
virtual CAEXSequence<T>^ Container() override
```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>\[Missing <typeparam name="T"/> documentation for "M:Aml.Engine.CAEX.InterfaceClassType.Container``1"\]</dd></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence</a>(*T*)<br />The CAEX container

#### Implements
<a href="M_Aml_Engine_CAEX_ICAEXBasicObject_Container__1">ICAEXBasicObject.Container(T)()</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InterfaceClassType">InterfaceClassType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />