# SplitService Class
AutomationML 2.1 API 

This class is an implementation of a split service. This service is able to split one <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a> into multiple files using split points.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.SplitService<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class SplitService : ISplit, 
	IAMLService, IXMLDocumentRegistry
```

**VB**<br />
``` VB
Public Class SplitService
	Implements ISplit, IAMLService, IXMLDocumentRegistry
```

**C++**<br />
``` C++
public ref class SplitService : ISplit, 
	IAMLService, IXMLDocumentRegistry
```

The SplitService type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_SplitService_Register">Register</a></td><td>
Registers a new instance of a SplitService with the <a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator</a> of the AMLEngine.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_SplitService_RemoveDocument">RemoveDocument</a></td><td>
Removes the document from the internal registry of the split service. All registered split points for this document will be removed.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_SplitService_RemoveSplitPoint">RemoveSplitPoint</a></td><td>
Removes the split point for the provided CAEX object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_SplitService_SetSplitPoint">SetSplitPoint</a></td><td>
Sets the split point for the provided CAEX object. If the actual list of split points for the same document already contains a split point which is a child of the provided CAEX object, this existing split point is removed from the list.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_SplitService_Split_1">Split(CAEXDocument, String, String)</a></td><td>
Splits the specified document on all currently defined split points. The created libraries are saved in an AutomationML document and an ExternalReference is created, using the specified alias. All remaining references to the external source are renamed using the provided alias. After splitting, the document doesn't contain any SplitPoints any more.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_SplitService_Split">Split(CAEXDocument, ISplitPoint, String, String)</a></td><td>
Splits the specified source document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_SplitService_SplitPoints">SplitPoints</a></td><td>
Gets a collection of all split points for the provided document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_SplitService_UnRegister">UnRegister</a></td><td>
Unregisters this service</td></tr></table>&nbsp;
<a href="#splitservice-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_ISplit">Aml.Engine.Services.Interfaces.ISplit</a><br />