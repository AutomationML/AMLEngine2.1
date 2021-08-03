# IQuery.AllClassReferences Method (CAEXDocument, String, String)
AutomationML 2.1 API 

Gets all classes which have references to the provided class path. Use this method to get all classes which have a class to class relation to the class, identified by the provided classPath. If the *elementName* is set, only classes with the defined element name are considered.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
IEnumerable<CAEXObject> AllClassReferences(
	CAEXDocument document,
	string classPath,
	string elementName = ""
)
```

**VB**<br />
``` VB
Function AllClassReferences ( 
	document As CAEXDocument,
	classPath As String,
	Optional elementName As String = ""
) As IEnumerable(Of CAEXObject)
```

**C++**<br />
``` C++
IEnumerable<CAEXObject^>^ AllClassReferences(
	CAEXDocument^ document, 
	String^ classPath, 
	String^ elementName = L""
)
```


#### Parameters
&nbsp;<dl><dt>document</dt><dd>Type: <a href="T_Aml_Engine_CAEX_CAEXDocument">Aml.Engine.CAEX.CAEXDocument</a><br />The CAEX document which is searched through.</dd><dt>classPath</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />The class path.</dd><dt>elementName (Optional)</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">System.String</a><br />Name of the element. Valid values are 'RoleClass', 'SystemUnitClass', 'InterfaceClass' and 'AttributeType'.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject</a>)<br />An enumeration of all classes which use the identified class as a base class.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery Interface</a><br /><a href="Overload_Aml_Engine_Services_Interfaces_IQuery_AllClassReferences">AllClassReferences Overload</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />