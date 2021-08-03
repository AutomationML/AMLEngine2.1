# AMLFile.MaximalAMLVersion Property 
AutomationML 2.1 API 

Gets the maximal AutomationML version, which can be associated with this AMLFile. The maximal AutomationML version depends on the used CAEX version. For CAEX 2.15 the maximal AutomationML version is 2.0. For CAEX 3.0 the maximal version is 2.10.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public Version MaximalAMLVersion { get; }
```

**VB**<br />
``` VB
Public ReadOnly Property MaximalAMLVersion As Version
	Get
```

**C++**<br />
``` C++
public:
property Version^ MaximalAMLVersion {
	Version^ get ();
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.version" target="_parent" rel="noopener noreferrer">Version</a>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />