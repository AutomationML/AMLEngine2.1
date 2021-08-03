# IUndoRedo Methods
AutomationML 2.1 API 

The <a href="T_Aml_Engine_Services_Interfaces_IUndoRedo">IUndoRedo</a> type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_BeginTransaction">BeginTransaction</a></td><td>
Begins a new transaction. All changes, made to a CAEXDocument inside a transaction are treated as a single operation.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_CanRedo">CanRedo</a></td><td>
Determines, if the service can redo a command</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_CanUndo">CanUndo</a></td><td>
Determines, if the service can undo a command</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_ClearStacks">ClearStacks</a></td><td>
Clears the undo and redo stacks.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_EndTransaction">EndTransaction</a></td><td>
Ends the current transaction.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_LastModificationDate">LastModificationDate</a></td><td>
Gets the date of the most recently executed command for the specified document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_Pause">Pause</a></td><td>
Request to not record changes of the specified document. If the recording of document changes is paused the <a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_Undo">Undo(CAEXDocument)</a> and <a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_Redo">Redo(CAEXDocument)</a> methods can not be applied.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_PushCommand">PushCommand</a></td><td>
A new command is pushed on the undo stack of this service.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_Redo">Redo</a></td><td>
Redo the most recently operation, which was undone</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_RedoActions">RedoActions</a></td><td>
Gets all command names of the actions in the redo stack for the provided CAEX document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_Resume">Resume</a></td><td>
Request to resume recording changes of the specified document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_Undo">Undo</a></td><td>
Undo of the last operation</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_Services_Interfaces_IUndoRedo_UndoActions">UndoActions</a></td><td>
Gets all command names of the actions in the undo stack for the provided CAEX document.</td></tr></table>&nbsp;
<a href="#iundoredo-methods">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_Interfaces_IUndoRedo">IUndoRedo Interface</a><br /><a href="N_Aml_Engine_Services_Interfaces">Aml.Engine.Services.Interfaces Namespace</a><br />