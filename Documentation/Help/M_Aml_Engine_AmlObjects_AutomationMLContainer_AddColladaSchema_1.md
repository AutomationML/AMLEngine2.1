# AutomationMLContainer.AddColladaSchema Method (String, Uri)
AutomationML 2.1 API 

Adds a COLLADA schema file to the package and creates a package - part relationship to the package using <a href="F_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_ColladaSchema">ColladaSchema</a>.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public PackagePart AddColladaSchema(
	string fileName,
	Uri partUri
)
```

**VB**<br />
``` VB
Public Function AddColladaSchema ( 
	fileName As String,
	partUri As Uri
) As PackagePart
```

**C++**<br />
``` C++
public:
PackagePart^ AddColladaSchema(
	String^ fileName, 
	Uri^ partUri
)
```


#### Parameters
&nbsp;<dl><dt>fileName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />full name of the file which should be added</dd><dt>partUri</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.uri" target="_parent" rel="noopener noreferrer">System.Uri</a><br />package internal name of the part</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart" target="_parent" rel="noopener noreferrer">PackagePart</a><br />added part

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">AutomationMLContainer Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_AutomationMLContainer_AddColladaSchema">AddColladaSchema Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />