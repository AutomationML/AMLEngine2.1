# AMLFile.GenericAdditionalInformation Property 
AutomationML 2.1 API 

Gets the AdditionalInformation values contained in this instance which are neither DocumentVersion or WriterHeader. DocumentVersion and WriterHeader objects are realized using AdditionalInformation objects, too. But these elements define a specific syntax to be recognized as specific AdditionalInformation objects.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ValueSequence<Object> GenericAdditionalInformation { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property GenericAdditionalInformation As ValueSequence(Of Object)
	Get
```

**C++**<br />
``` C++
public:
property ValueSequence<Object^>^ GenericAdditionalInformation {
	ValueSequence<Object^>^ get ();
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_ValueSequence_1">ValueSequence</a>(<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">Object</a>)

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />