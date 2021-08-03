# ISplit Interface
AutomationML 2.1 API 

This interface defines the service interface for a split service. A split service is able to split one <a href="T_Aml_Engine_CAEX_CAEXDocument">CAEXDocument</a> into multiple files using split points.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public interface ISplit : IAMLService
```

**VB**<br />
``` VB
Public Interface ISplit
	Inherits IAMLService
```

**C++**<br />
``` C++
public interface class ISplit : IAMLService
```

The ISplit type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_ISplit_RemoveSplitPoint">RemoveSplitPoint</a></td><td>
Removes the split point for the provided CAEX object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_ISplit_SetSplitPoint">SetSplitPoint</a></td><td>
Sets the split point for the provided CAEX object. If the actual list of split points for the same document already contains a split point which is a child of the provided CAEX object, this existing split point is removed from the list.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_ISplit_Split_1">Split(CAEXDocument, String, String)</a></td><td>
Splits the specified document on all currently defined split points. The created libraries are saved in an AutomationML document and an ExternalReference is created, using the specified alias. All remaining references to the external source are renamed using the provided alias. After splitting, the document doesn't contain any SplitPoints any more.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_ISplit_Split">Split(CAEXDocument, ISplitPoint, String, String)</a></td><td>
Splits the specified document on only the specified split point. The created library is saved in an AutomationML document and an ExternalReference is created, using the specified alias. All remaining references to the external source are renamed using the provided alias. After splitting, the document doesn't contain this SplitPoints any more.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_ISplit_SplitPoints">SplitPoints</a></td><td>
Gets a collection of all split points for the provided document.</td></tr></table>&nbsp;
<a href="#isplit-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IAMLService">Aml.Engine.Services.Interfaces.IAMLService</a><br />