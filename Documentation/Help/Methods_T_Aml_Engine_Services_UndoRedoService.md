# UndoRedoService Methods
AutomationML 2.1 API 

The <a href="T_Aml_Engine_Services_UndoRedoService">UndoRedoService</a> type exposes the following members.


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
<a href="#undoredoservice-methods">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_UndoRedoService">UndoRedoService Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />