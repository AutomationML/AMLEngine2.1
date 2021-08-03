# QueryService.AllClassReferencesDeep Method (CAEXDocument, String, String)
AutomationML 2.1 API 

Gets all classes which have references to the provided CAEX object and their referencing classes (recursive). This method extends the <a href="M_Aml_Engine_Services_QueryService_AllClassReferences">AllClassReferences(CAEXDocument, String, String)</a> and gets not only the directly derived classes of a base class but also the derived classes of these classes and further on. If the *elementName* is set, only classes with the defined element name are considered.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<CAEXObject> AllClassReferencesDeep(
	CAEXDocument document,
	string classPath,
	string elementName = ""
)
```

**VB**<br />
``` VB
Public Function AllClassReferencesDeep ( 
	document As CAEXDocument,
	classPath As String,
	Optional elementName As String = ""
) As IEnumerable(Of CAEXObject)
```

**C++**<br />
``` C++
public:
virtual IEnumerable<CAEXObject^>^ AllClassReferencesDeep(
	CAEXDocument^ document, 
	String^ classPath, 
	String^ elementName = L""
) sealed
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document which is searched through.</dd><dt>classPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The class path.</dd><dt>elementName (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the element. Valid values are 'RoleClass', 'SystemUnitClass', 'InterfaceClass' and 'AttributeType'.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>)<br />\[Missing <returns> documentation for "M:Aml.Engine.Services.QueryService.AllClassReferencesDeep(Aml.Engine.CAEX.CAEXDocument,System.String,System.String)"\]

#### Implements
<a href="M_Aml_Engine_Services_Interfaces_IQuery_AllClassReferencesDeep">IQuery.AllClassReferencesDeep(CAEXDocument, String, String)</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryService">QueryService Class</a><br /><a href="Overload_Aml_Engine_Services_QueryService_AllClassReferencesDeep">AllClassReferencesDeep Overload</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />