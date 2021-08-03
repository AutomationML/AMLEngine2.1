# DocumentVersionInformation Class
AutomationML 2.1 API 

This Class is defined for the modeling of document version information as defined in the AutomationML BPR 06 "Naming of related documents and their versions". <a href="T_Aml_Engine_AmlObjects_DocumentVersions">DocumentVersions</a> are stored as <a href="P_Aml_Engine_CAEX_CAEXBasicObject_AdditionalInformation">AdditionalInformation</a> attached to the CAEXFile Node of the AMLDocument.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.AmlObjects.DocumentVersionInformation<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class DocumentVersionInformation
```

**VB**<br />
``` VB
Public Class DocumentVersionInformation
```

**C++**<br />
``` C++
public ref class DocumentVersionInformation
```

The DocumentVersionInformation type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_DocumentVersionInformation__ctor">DocumentVersionInformation()</a></td><td>
Initializes a new instance of the DocumentVersionInformation class.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_DocumentVersionInformation__ctor_1">DocumentVersionInformation(XElement)</a></td><td>
Initializes a new instance of the DocumentVersionInformation class using the provided XML node (this should be an <a href="F_Aml_Engine_CAEX_CAEX_CLASSModel_TagNames_ADDITIONALINFORMATION_STRING">ADDITIONALINFORMATION_STRING</a>), containing document content.</td></tr></table>&nbsp;
<a href="#documentversioninformation-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_DocumentVersionInformation_DocumentIdentifier">DocumentIdentifier</a></td><td>
The document attribute "DocumentIdentifier" shall define the name of the referenced document.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_DocumentVersionInformation_Version">Version</a></td><td>
The document attribute "Version" shall define the version range of the referenced document.</td></tr></table>&nbsp;
<a href="#documentversioninformation-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />