# CAEXReference Class
AutomationML 2.1 API 

This class is used in queries to provide information about objects, which contain references to other objects.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.CAEXReference<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class CAEXReference : ICAEXReference
```

**VB**<br />
``` VB
Public Class CAEXReference
	Implements ICAEXReference
```

**C++**<br />
``` C++
public ref class CAEXReference : ICAEXReference
```

The CAEXReference type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_CAEXReference__ctor">CAEXReference</a></td><td>
Initializes a new instance of the CAEXReference class.</td></tr></table>&nbsp;
<a href="#caexreference-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_CAEXReference_CaexObject">CaexObject</a></td><td>
Gets the CAEX object which contains the reference.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_CAEXReference_Element">Element</a></td><td>
Gets the XML element, which contains the reference.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_CAEXReference_ReferenceAttributeName">ReferenceAttributeName</a></td><td>
Gets the name of the reference attribute which contains the value of the reference. To get or set the attribute value for the attribute with this name the <a href="M_Aml_Engine_CAEX_CAEXWrapper_SetXAttributeValue">SetXAttributeValue(XName, Object)</a> and <a href="M_Aml_Engine_CAEX_CAEXWrapper_GetXAttributeValue">GetXAttributeValue(XName)</a> methods can be used.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_CAEXReference_ReferenceAttributeValue">ReferenceAttributeValue</a></td><td>
Gets the reference attribute value.</td></tr></table>&nbsp;
<a href="#caexreference-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_ICAEXReference">Aml.Engine.Services.Interfaces.ICAEXReference</a><br />