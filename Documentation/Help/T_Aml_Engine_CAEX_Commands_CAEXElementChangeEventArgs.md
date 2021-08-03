# CAEXElementChangeEventArgs Class
AutomationML 2.1 API 

Event arguments for a <a href="E_Aml_Engine_CAEX_Commands_CaexCommand_CAEXElementChangingEvent">CAEXElementChangingEvent</a> and a <a href="E_Aml_Engine_CAEX_Commands_CaexCommand_CAEXElementChangedEvent">CAEXElementChangedEvent</a>


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;<a href="https://docs.microsoft.com/dotnet/api/system.eventargs" target="_parent" rel="noopener noreferrer">System.EventArgs</a><br />&nbsp;&nbsp;&nbsp;&nbsp;Aml.Engine.CAEX.Commands.CAEXElementChangeEventArgs<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class CAEXElementChangeEventArgs : EventArgs
```

**VB**<br />
``` VB
Public Class CAEXElementChangeEventArgs
	Inherits EventArgs
```

**C++**<br />
``` C++
public ref class CAEXElementChangeEventArgs : public EventArgs
```

The CAEXElementChangeEventArgs type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs__ctor">CAEXElementChangeEventArgs(XElement, XElement, CAEXDocument, CAEXElementChangeMode)</a></td><td>
Constructs arguments for an element changing event</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs__ctor_1">CAEXElementChangeEventArgs(XElement, XElement, CAEXDocument, XAttribute, String, Object, Object, CAEXElementChangeMode)</a></td><td>
Constructs arguments for an element's attribute changing event</td></tr></table>&nbsp;
<a href="#caexelementchangeeventargs-class">Back to Top</a>

## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs_CAEXAttribute">CAEXAttribute</a></td><td>
The changed CAEXAttribute</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs_CAEXAttributeName">CAEXAttributeName</a></td><td>
Gets the name of the CAEX attribute.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs_CAEXDocument">CAEXDocument</a></td><td>
Gets the CAEX document.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs_CAEXElement">CAEXElement</a></td><td>
The changed CAEXElement</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs_CAEXParent">CAEXParent</a></td><td>
The changed CAEXElement's parent. This Property should be used, to detect a former parent of a CAEXElement, when the CAEXElement has been deleted and has no associated parent.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs_ChangeMode">ChangeMode</a></td><td>
The change mode</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs_NewValue">NewValue</a></td><td>
The new value</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Commands_CAEXElementChangeEventArgs_OldValue">OldValue</a></td><td>
The old value</td></tr></table>&nbsp;
<a href="#caexelementchangeeventargs-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands Namespace</a><br />