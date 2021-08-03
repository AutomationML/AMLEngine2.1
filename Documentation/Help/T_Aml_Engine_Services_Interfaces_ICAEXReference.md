# ICAEXReference Interface
AutomationML 2.1 API 

This interface is used to query references to CAEXObjects like references using the ID of objects or references using the CAEXPath of objects like RoleClass or InterfaceClass objects.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public interface ICAEXReference
```

**VB**<br />
``` VB
Public Interface ICAEXReference
```

**C++**<br />
``` C++
public interface class ICAEXReference
```

The ICAEXReference type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_Interfaces_ICAEXReference_CaexObject">CaexObject</a></td><td>
Gets the CAEX object which owns the reference.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_Interfaces_ICAEXReference_ReferenceAttributeName">ReferenceAttributeName</a></td><td>
Gets the name of the reference attribute which contains the value of the reference. To get or set the attribute value the <a href="M_Aml_Engine_CAEX_CAEXWrapper_SetXAttributeValue">SetXAttributeValue(XName, Object)</a> an <a href="M_Aml_Engine_CAEX_CAEXWrapper_GetXAttributeValue">GetXAttributeValue(XName)</a> methods can be used.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_Interfaces_ICAEXReference_ReferenceAttributeValue">ReferenceAttributeValue</a></td><td>
Gets the reference attribute value.</td></tr></table>&nbsp;
<a href="#icaexreference-interface">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />