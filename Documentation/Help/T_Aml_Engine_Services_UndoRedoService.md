# UndoRedoService Class
AutomationML 2.1 API 

This class implements an Undo and Redo service. When this service is registered, changes in an AutomationML document can be reversed. A sequence of actions can be grouped into transactions which than can be reversed within a single undo operation. The AMLEngine will locate a registered UndoRedoService and will notify the service of any changes, made to a document. The service manages individual stacks for each loaded CAEX document.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.UndoRedoService<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine.Services (in AML.Engine.Services.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class UndoRedoService : IUndoRedo, 
	IAMLService, INotifyPropertyChanged, IXMLDocumentRegistry
```

**VB**<br />
``` VB
Public Class UndoRedoService
	Implements IUndoRedo, IAMLService, INotifyPropertyChanged, IXMLDocumentRegistry
```

**C++**<br />
``` C++
public ref class UndoRedoService : IUndoRedo, 
	IAMLService, INotifyPropertyChanged, IXMLDocumentRegistry
```

The UndoRedoService type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_BeginTransaction">BeginTransaction</a></td><td>
Begins a new transaction. All changes, made to a CAEXDocument inside a transaction are treated as a single operation.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_CanRedo">CanRedo</a></td><td>
Determines, if the service can redo a command</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_CanUndo">CanUndo</a></td><td>
Determines, if the service can undo a command.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_ClearStacks">ClearStacks</a></td><td>
Clears the stacks, managed for the specified document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_EndTransaction">EndTransaction</a></td><td>
Ends the current transaction from the specified document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_LastModificationDate">LastModificationDate</a></td><td>
Gets the date of the most recently executed command for the specified document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_Pause">Pause</a></td><td>
Request to not record changes of the specified document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_PushCommand">PushCommand</a></td><td>
A command is pushed on the undo stack of this service.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_Redo">Redo</a></td><td>
Executes the last undone operation from the specified document again.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_RedoActions">RedoActions</a></td><td>
Gets the command names of all redo actions for the defined document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_Register">Register</a></td><td>
Registers a new instance of a UndoRedoService with the <a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator</a> of the AMLEngine.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_RemoveDocument">RemoveDocument</a></td><td>
Removes the XML document from the internal registry of the service. Undo- and Redo Stacks for this document will be deleted.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_Resume">Resume</a></td><td>
Request to resume recording changes of the specified document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_Undo">Undo</a></td><td>
Reverses the last action of the defined document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_UndoActions">UndoActions</a></td><td>
Gets the command names of all undo actions of the defined document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_UndoRedoService_UnRegister">UnRegister</a></td><td>
Unregisters this service</td></tr></table>&nbsp;
<a href="#undoredoservice-class">Back to Top</a>

## Events
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public event](media/pubevent.gif "Public event")</td><td><a href="E_Aml_Engine_Services_UndoRedoService_PropertyChanged">PropertyChanged</a></td><td>
Occurs when a property value changes.</td></tr></table>&nbsp;
<a href="#undoredoservice-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br /><a href="T_Aml_Engine_Services_Interfaces_IUndoRedo">Aml.Engine.Services.Interfaces.IUndoRedo</a><br /><a href="https://docs.microsoft.com/dotnet/api/system.componentmodel.inotifypropertychanged" target="_parent" rel="noopener noreferrer">System.ComponentModel.INotifyPropertyChanged</a><br />