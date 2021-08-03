# ServiceLocator Properties
AutomationML 2.1 API 

The <a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator</a> type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Aml_Engine_Services_ServiceLocator_AutoUpdateService">AutoUpdateService</a></td><td>
Gets the automatic update service.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Aml_Engine_Services_ServiceLocator_QueryService">QueryService</a></td><td>
Gets the registered Query-Service. If no Query-Service is registered, a default Query-Service - which is based on LinqToXml - is returned. As an alternative, a Query-Service based on Dictionaries for keyed access is available. The dictionary based service has to be registered to be used. If no such service has been registered, the default query service is returned. The actual registered Query-Service is located by the engine and used for all queries.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Aml_Engine_Services_ServiceLocator_UndoRedoService">UndoRedoService</a></td><td>
Gets the registered UndoRedo-Service. The actual registered UndoRedo-Service is located by the engine and used to push executed commands on the undo stack. If no UndoRedo-Service is registered executed commands are not pushed and cannot be undone.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")![Static member](media/static.gif "Static member")</td><td><a href="P_Aml_Engine_Services_ServiceLocator_UniqueNameService">UniqueNameService</a></td><td>
Gets the registered UniqueName-Service.The actual registered UniqueName-Service is located by the engine to automatically assign unique names to CAEXObjects if they are inserted into a sequence. If no UniqueName-Service is registered no names are generated.</td></tr></table>&nbsp;
<a href="#servicelocator-properties">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />