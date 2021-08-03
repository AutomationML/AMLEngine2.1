# MergeService Class
AutomationML 2.1 API 

This class implements a merge service which is able to merge CAEX documents from different sources into one common document. The merge service adds the libraries from the external referenced file into the target document and updates all references, which use an alias and can be resolved after the merge. If a library, which is used in the external source, also exists in the target document, this library is replaced, if the library version in the external source is newer. If not the existing library is kept. If an InstanceHierarchy in the external source can be identified as an outsourced Master InternalElement, it is tried to add the Master InternalElement back to its original position.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.MergeService<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class MergeService : IMerge, 
	IAMLService
```

**VB**<br />
``` VB
Public Class MergeService
	Implements IMerge, IAMLService
```

**C++**<br />
``` C++
public ref class MergeService : IMerge, 
	IAMLService
```

The MergeService type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_MergeService__ctor">MergeService</a></td><td>
Initializes a new instance of the MergeService class</td></tr></table>&nbsp;
<a href="#mergeservice-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_MergeService_Merge_1">Merge(CAEXDocument, ExternalReferenceType, String[], Boolean)</a></td><td>
Merges the defined ExternalReference into the provided CAEXDocument.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_MergeService_Merge">Merge(CAEXDocument, ExternalReferenceType, Stream, String[], Boolean)</a></td><td>
Merges the defined ExternalReference into the provided CAEXDocument. The source is loaded from the provided external source stream.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_MergeService_Register">Register</a></td><td>
Registers a new instance of a MergeService with the <a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator</a> of the AMLEngine.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_MergeService_UnRegister">UnRegister</a></td><td>
Unregisters this service</td></tr></table>&nbsp;
<a href="#mergeservice-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IMerge">Aml.Engine.Services.Interfaces.IMerge</a><br />