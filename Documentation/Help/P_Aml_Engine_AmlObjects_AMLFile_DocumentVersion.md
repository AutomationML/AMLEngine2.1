# AMLFile.DocumentVersion Property 
AutomationML 2.1 API 

Gets the collection of defined document version information of the AMLFile

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public ValueSequence<DocumentVersionInformation> DocumentVersion { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property DocumentVersion As ValueSequence(Of DocumentVersionInformation)
	Get
```

**C++**<br />
``` C++
public:
property ValueSequence<DocumentVersionInformation^>^ DocumentVersion {
	ValueSequence<DocumentVersionInformation^>^ get ();
}
```


#### Property Value
Type: <a href="T_Aml_Engine_CAEX_ValueSequence_1">ValueSequence</a>(<a href="T_Aml_Engine_AmlObjects_DocumentVersionInformation">DocumentVersionInformation</a>)<br />The collection of document version information.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />