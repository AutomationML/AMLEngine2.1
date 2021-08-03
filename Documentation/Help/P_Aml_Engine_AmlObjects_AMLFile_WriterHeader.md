# AMLFile.WriterHeader Property 
AutomationML 2.1 API 

Gets the collection of defined writer headers of the AMLFile

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ValueSequence<MetaInformation> WriterHeader { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property WriterHeader As ValueSequence(Of MetaInformation)
	Get
```

**C++**<br />
``` C++
public:
property ValueSequence<MetaInformation^>^ WriterHeader {
	ValueSequence<MetaInformation^>^ get ();
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_ValueSequence_1">ValueSequence</a>(<a href="T_Aml_Engine_AmlObjects_MetaInformation">MetaInformation</a>)<br />The collection writer header.

## Remarks
valid only for AutomationML Version 2.0 using CAEX 2.15

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />