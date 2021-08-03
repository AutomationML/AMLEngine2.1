# DocumentVersionInformation.Version Property 
AutomationML 2.1 API 

The document attribute "Version" shall define the version range of the referenced document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public string Version { get; set; }
```

**VB**<br />
``` VB
Public Property Version As String
	Get
	Set
```

**C++**<br />
``` C++
public:
property String^ Version {
	String^ get ();
	void set (String^ value);
}
```


#### Property Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The version number shall have three numbers separated by ".". The three numbers define "main version", "minor version" and "revision".

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_DocumentVersionInformation">DocumentVersionInformation Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />