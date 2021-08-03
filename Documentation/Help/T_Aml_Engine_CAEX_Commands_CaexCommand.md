# CaexCommand Class
AutomationML 2.1 API 

This is the abstract base class for all CAEX commands, applicable to CAEX elements


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.CAEX.Commands.CaexCommand<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public abstract class CaexCommand : ICAEXCommand
```

**VB**<br />
``` VB
Public MustInherit Class CaexCommand
	Implements ICAEXCommand
```

**C++**<br />
``` C++
public ref class CaexCommand abstract : ICAEXCommand
```

The CaexCommand type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Commands_CaexCommand_CAEXDocument">CAEXDocument</a></td><td>
Gets the CAEX document processing the command</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Commands_CaexCommand_DisplayName">DisplayName</a></td><td>
Gets the display name of the command</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Commands_CaexCommand_XDocument">XDocument</a></td><td>
Gets the XML document processing the command</td></tr></table>&nbsp;
<a href="#caexcommand-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_Commands_CaexCommand_Execute">Execute</a></td><td>
Command Execution method</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Commands_CaexCommand_OnCAEXElementChangedEvent">OnCAEXElementChangedEvent</a></td><td>
Raises the <a href="E_Aml_Engine_CAEX_Commands_CaexCommand_CAEXElementChangedEvent">CAEXElementChangedEvent</a> for the provided document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Commands_CaexCommand_OnCAEXElementChangingEvent">OnCAEXElementChangingEvent</a></td><td>
Raises the <a href="E_Aml_Engine_CAEX_Commands_CaexCommand_CAEXElementChangingEvent">CAEXElementChangingEvent</a> for the provided document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_Commands_CaexCommand_UnExecute">UnExecute</a></td><td>
Command reverse execution method</td></tr></table>&nbsp;
<a href="#caexcommand-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")![Static member](media/static.gif "Static member")</td><td><a href="E_Aml_Engine_CAEX_Commands_CaexCommand_CAEXElementChangedEvent">CAEXElementChangedEvent</a></td><td>
This event is raised after a CAEXElement has been changed. <a href="T_Aml_Engine_CAEX_Commands_CAEXElementChangeMode">CAEXElementChangeMode</a></td></tr><tr><td>![Public event](media/pubevent.gif "Public event")![Static member](media/static.gif "Static member")</td><td><a href="E_Aml_Engine_CAEX_Commands_CaexCommand_CAEXElementChangingEvent">CAEXElementChangingEvent</a></td><td>
This event is raised before a CAEXElement will be changed. <a href="T_Aml_Engine_CAEX_Commands_CAEXElementChangeMode">CAEXElementChangeMode</a></td></tr></table>&nbsp;
<a href="#caexcommand-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX_Commands">Aml.Engine.CAEX.Commands Namespace</a><br />