# AutomationMLContainer.AddAnyContent Method (PackagePart, String, Uri, String, Boolean)
AutomationML 2.1 API 

Adds any content to the package creating relationships to the package and to the part, containing the root document using the relationship type <a href="F_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_AnyContent">AnyContent</a>.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public PackagePart AddAnyContent(
	PackagePart rootDocument,
	string fileName,
	Uri partUri,
	string mimeType = null,
	bool addPackageRelation = true
)
```

**VB**<br />
``` VB
Public Function AddAnyContent ( 
	rootDocument As PackagePart,
	fileName As String,
	partUri As Uri,
	Optional mimeType As String = Nothing,
	Optional addPackageRelation As Boolean = true
) As PackagePart
```

**C++**<br />
``` C++
public:
PackagePart^ AddAnyContent(
	PackagePart^ rootDocument, 
	String^ fileName, 
	Uri^ partUri, 
	String^ mimeType = nullptr, 
	bool addPackageRelation = true
)
```


#### Parameters
&nbsp;<dl><dt>rootDocument</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart" target="_parent" rel="noopener noreferrer">System.IO.Packaging.PackagePart</a><br />package part, containing the parent root document</dd><dt>fileName</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />full name of the file which should be added</dd><dt>partUri</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.uri" target="_parent" rel="noopener noreferrer">System.Uri</a><br />package internal name of the part</dd><dt>mimeType (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />optional mime type, the default mime type for the relationship is used if empty</dd><dt>addPackageRelation (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.boolean" target="_parent" rel="noopener noreferrer">System.Boolean</a><br />optional parameter, defining if a package relation should be added</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.io.packaging.packagepart" target="_parent" rel="noopener noreferrer">PackagePart</a><br />PackagePart.

##
&nbsp;<table><tr><th /><th /><th /></tr><tr><td>08/03/2021</td><td>1.6.3.0</td><td>*addPackageRelation* added as an additional optional parameter, defining if a package relation should be added.</td></tr></table>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AutomationMLContainer">AutomationMLContainer Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_AutomationMLContainer_AddAnyContent">AddAnyContent Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />