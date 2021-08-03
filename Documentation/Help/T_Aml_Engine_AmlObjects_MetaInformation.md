# MetaInformation Class
AutomationML 2.1 API 

Class for modelling meta information as defined in the AutomationML standard. This class was originally designed for AML Versions based on CAEX 2.15. For later versions you can switch to the <a href="T_Aml_Engine_CAEX_SourceDocumentInformationType">SourceDocumentInformationType</a>. It is possible to set SourceDocumentInformation in a CAEX 3.0 document using this class. If this is applied, the MetaInformation is automatically transformed to SourceDocumentInformation. The transformation works in both directions.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.AmlObjects.MetaInformation<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class MetaInformation
```

**VB**<br />
``` VB
Public Class MetaInformation
```

**C++**<br />
``` C++
public ref class MetaInformation
```

The MetaInformation type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_MetaInformation__ctor">MetaInformation()</a></td><td>
Initializes a new instance of the MetaInformation class.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_MetaInformation__ctor_2">MetaInformation(XElement)</a></td><td>
Initializes a new instance of the MetaInformation class, using a WriterHeader node to populate the properties.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_MetaInformation__ctor_1">MetaInformation(SourceDocumentInformationType)</a></td><td>
Initializes a new instance of the MetaInformation class using the information provided from the specified SourceDocumentInformation</td></tr></table>&nbsp;
<a href="#metainformation-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_MetaInformation_LastWritingDateTime">LastWritingDateTime</a></td><td>
time stamp of the AutomationML export</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_MetaInformation_WriterID">WriterID</a></td><td>
the ID of the writer tool, maybe identical to the tools name if it is not subject of change</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_MetaInformation_WriterName">WriterName</a></td><td>
the name of the writer tool (e.g. CoDeSys)</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_MetaInformation_WriterProjectID">WriterProjectID</a></td><td>
ID of the project that contains the source engineering data</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_MetaInformation_WriterProjectTitle">WriterProjectTitle</a></td><td>
name of the project that contains the source engineering data</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_MetaInformation_WriterRelease">WriterRelease</a></td><td>
release information about the writer tool, e.g. "beta12"</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_MetaInformation_WriterVendor">WriterVendor</a></td><td>
the vendor of the writer tool, e.g. "3S"</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_MetaInformation_WriterVendorURL">WriterVendorURL</a></td><td>
the web URL of the vendor - helps to get in contact to the vendor</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_MetaInformation_WriterVersion">WriterVersion</a></td><td>
version of the writer tool, e.g. "3.4"</td></tr></table>&nbsp;
<a href="#metainformation-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />