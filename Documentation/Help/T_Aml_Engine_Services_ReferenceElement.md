# ReferenceElement Class
AutomationML 2.1 API 

ReferenceElement is a Tuple of an XElement and the Name of an Attributes, which is used to reference another Element. The reference may be used as a key to find the referenced Element.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;<a href="https://docs.microsoft.com/dotnet/api/system.tuple-2" target="_parent" rel="noopener noreferrer">System.Tuple</a>(<a href="https://docs.microsoft.com/dotnet/api/system.xml.linq.xelement" target="_parent" rel="noopener noreferrer">XElement</a>, <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;Aml.Engine.Services.ReferenceElement<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class ReferenceElement : Tuple<XElement, string>, 
	ICAEXReference
```

**VB**<br />
``` VB
Public Class ReferenceElement
	Inherits Tuple(Of XElement, String)
	Implements ICAEXReference
```

**C++**<br />
``` C++
public ref class ReferenceElement : public Tuple<XElement^, String^>, 
	ICAEXReference
```

The ReferenceElement type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_ReferenceElement_CaexObject">CaexObject</a></td><td>
Gets the CAEX object which owns the reference.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_ReferenceElement_Element">Element</a></td><td>
Gets the XML node.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_ReferenceElement_ReferenceAttributeName">ReferenceAttributeName</a></td><td>
Gets the name of the reference attribute of the <a href="P_Aml_Engine_Services_ReferenceElement_Element">Element</a></td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_Services_ReferenceElement_ReferenceAttributeValue">ReferenceAttributeValue</a></td><td>
gets the value of the Reference Attribute</td></tr></table>&nbsp;
<a href="#referenceelement-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ReferenceElement_Equals">Equals</a></td><td>
Determines whether the specified <a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">Object</a> is equal to this instance.
 (Overrides <a href="https://docs.microsoft.com/dotnet/api/system.tuple-2.equals#System_Tuple_2_Equals_System_Object_" target="_parent" rel="noopener noreferrer">Tuple(T1, T2).Equals(Object)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_ReferenceElement_GetHashCode">GetHashCode</a></td><td>
Returns a hash code for this instance.
 (Overrides <a href="https://docs.microsoft.com/dotnet/api/system.tuple-2.gethashcode#System_Tuple_2_GetHashCode" target="_parent" rel="noopener noreferrer">Tuple(T1, T2).GetHashCode()</a>.)</td></tr></table>&nbsp;
<a href="#referenceelement-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />