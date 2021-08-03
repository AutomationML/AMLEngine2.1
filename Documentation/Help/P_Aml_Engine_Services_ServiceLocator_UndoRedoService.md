# ServiceLocator.UndoRedoService Property 
AutomationML 2.1 API 

Gets the registered UndoRedo-Service. The actual registered UndoRedo-Service is located by the engine and used to push executed commands on the undo stack. If no UndoRedo-Service is registered executed commands are not pushed and cannot be undone.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IUndoRedo UndoRedoService { get; }
```

**VB**<br />
``` VB
Public Shared ReadOnly Property UndoRedoService As IUndoRedo
	Get
```

**C++**<br />
``` C++
public:
static property IUndoRedo^ UndoRedoService {
	IUndoRedo^ get ();
}
```


#### Property Value
Type: <a href="T_Aml_Engine_Services_Interfaces_IUndoRedo">IUndoRedo</a>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />