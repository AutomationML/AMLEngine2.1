# AutomationMLContainer.RelationshipType Class
AutomationML 2.1 API 

Class RelationshipType describes the distinguished package part relationship types. This class cannot be inherited.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.AmlObjects.AutomationMLContainer.RelationshipType<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public sealed class RelationshipType : IComparable<AutomationMLContainer.RelationshipType>
```

**VB**<br />
``` VB
Public NotInheritable Class RelationshipType
	Implements IComparable(Of AutomationMLContainer.RelationshipType)
```

**C++**<br />
``` C++
public ref class RelationshipType sealed : IComparable<AutomationMLContainer.RelationshipType^>
```

The AutomationMLContainer.RelationshipType type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_MimeType">MimeType</a></td><td>
Gets the mime type of the relationship</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_Name">Name</a></td><td>
Gets the name of the relationship.</td></tr></table>&nbsp;
<a href="#automationmlcontainer.relationshiptype-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_CompareTo">CompareTo</a></td><td>
Compares the current instance's name to another object's name of the same type and returns an integer indicating whether the current instance's name occurs in the sort order before or after the other object or at the same position.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_GetAnyContent">GetAnyContent</a></td><td>
Creates a RelationshipType for any content. If no mime type is defined, the relationship type <a href="F_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_AnyContent">AnyContent</a> is used.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_ToString">ToString</a></td><td>
Returns the <a href="P_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_Name">Name</a> as the string representation of this instance.
 (Overrides <a href="https://docs.microsoft.com/dotnet/api/system.object.tostring#System_Object_ToString" target="_parent" rel="noopener noreferrer">Object.ToString()</a>.)</td></tr></table>&nbsp;
<a href="#automationmlcontainer.relationshiptype-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_AnyContent">AnyContent</a></td><td>
relationship type for package to part or root part to part relations to any content.</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_CAEXSchema">CAEXSchema</a></td><td>
relationship type for package to part relation to the CAEX schema part.</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_Collada">Collada</a></td><td>
relationship type for package to part or root part to part relations to a COLLADA part.</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_ColladaSchema">ColladaSchema</a></td><td>
relationship type for package to part relation to the COLLADA schema.</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_Library">Library</a></td><td>
relationship type for package to part or root part to part relations to a part, containing an AutomationML library.</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_PLCopenXml">PLCopenXml</a></td><td>
relationship type for package to part or root part to part relations to a PLCopenXml part.</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_PLCopenXmlSchema">PLCopenXmlSchema</a></td><td>
relationship type for package to part relation to the PLCopenXml schema.</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_AutomationMLContainer_RelationshipType_Root">Root</a></td><td>
relationship type for the package to part relation to the part containing the root document.</td></tr></table>&nbsp;
<a href="#automationmlcontainer.relationshiptype-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />