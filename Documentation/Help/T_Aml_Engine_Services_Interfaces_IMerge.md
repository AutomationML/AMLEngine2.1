# IMerge Interface
AutomationML 2.1 API 

This interface defines methods for a merge service. A merge service can merge ExternalReferences into an AML document.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public interface IMerge : IAMLService
```

**VB**<br />
``` VB
Public Interface IMerge
	Inherits IAMLService
```

**C++**<br />
``` C++
public interface class IMerge : IAMLService
```


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IMerge_Merge_1">Merge(CAEXDocument, ExternalReferenceType, String[], Boolean)</a></td><td>
Merges the defined ExternalReference into the provided CAEXDocument. The source is loaded from the file path in the external reference.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IMerge_Merge">Merge(CAEXDocument, ExternalReferenceType, Stream, String[], Boolean)</a></td><td>
Merges the defined ExternalReference into the provided CAEXDocument. The source is loaded from the provided external source stream.</td></tr></table>&nbsp;
<a href="#imerge-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IAMLService">Aml.Engine.Services.Interfaces.IAMLService</a><br />