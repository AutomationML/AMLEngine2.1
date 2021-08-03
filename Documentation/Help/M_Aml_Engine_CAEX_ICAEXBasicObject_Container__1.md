# ICAEXBasicObject.Container(*T*) Method 
AutomationML 2.1 API 

Gets the CAEXSequence for elements of type T, which is owned by this CAEX object.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
CAEXSequence<T> Container<T>()
where T : CAEXWrapper

```

**VB**<br />
``` VB
Function Container(Of T As CAEXWrapper) As CAEXSequence(Of T)
```

**C++**<br />
``` C++
generic<typename T>
where T : CAEXWrapperCAEXSequence<T>^ Container()
```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd /></dl>

#### Return Value
Type: <a href="T_Aml_Engine_CAEX_CAEXSequence_1">CAEXSequence</a>(*T*)<br />The CAEX container

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ICAEXBasicObject">ICAEXBasicObject Interface</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />