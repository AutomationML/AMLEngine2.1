# AMLFile.AutomationMLVersion Property 
AutomationML 2.1 API 

Gets or sets the AutomationML version. It is not allowed to set an AMLVersion which is higher than the <a href="P_Aml_Engine_AmlObjects_AMLFile_MaximalAMLVersion">MaximalAMLVersion</a>. If this is tried, the maximal known version is used for this document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public string AutomationMLVersion { get; set; }
```

**VB**<br />
``` VB
Public Property AutomationMLVersion As String
	Get
	Set
```

**C++**<br />
``` C++
public:
property String^ AutomationMLVersion {
	String^ get ();
	void set (String^ value);
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />