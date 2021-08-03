# ExternalDataReference Class
AutomationML 2.1 API 

This class provides methods to create and retrieve external data references as it is defined in the BPR document "ExternalDataReference" Version 1.0.0 from July 2016.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.AmlObjects.ExternalDataReference<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class ExternalDataReference
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public NotInheritable Class ExternalDataReference
```

**C++**<br />
``` C++
[ExtensionAttribute]
public ref class ExternalDataReference abstract sealed
```

The ExternalDataReference type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_AddAutomationMLBPRInterfaceClassLib">AddAutomationMLBPRInterfaceClassLib</a></td><td>
Adds the AutomationMLBPRInterfaceClassLib containing all interface classes used to model external document references to the AMLDocument.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_AddAutomationMLBPRRoleClassLib">AddAutomationMLBPRRoleClassLib</a></td><td>
Adds the AutomationMLBPRRoleClassLib containing all role classes used to model external document references to the AMLDocument.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_AddDocumentElement">AddDocumentElement</a></td><td>
Adds a document element to the defined internalElement. A Document Element is semantically described with an attached role defined with the base role class <a href="F_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClassPath">ExternalDataRoleClassPath</a> or a derived role class. If no role class path is given as a parameter the default is used. If the specified role class path can not be identified as a derived role from the <a href="F_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClassPath">ExternalDataRoleClassPath</a> no document element is added (returns null).</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_AddDocumentElementRole">AddDocumentElementRole</a></td><td>
Add a role reference to a external data role class or derived role class defined with the given role class path as a supported role class to the internal element. If the specified role class path can not be identified as a derived role from the <a href="F_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClassPath">ExternalDataRoleClassPath</a> no role reference is added (returns false).</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_AddDocumentReference">AddDocumentReference</a></td><td>
Adds a document with the specified external reference interface to the document element. If the given internal element is not a document element or the defined class path to the external reference interface is not derived from the standard base class no interface is added.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_AddExternalDataReferenceLibraries">AddExternalDataReferenceLibraries</a></td><td>
Adds the external data reference libraries used to model external document references. It is checked, if the needed role- and interface libraries are contained in the AMLDocument. If this libs are missing, they are imported from an embedded resource stream. The current Version of the embedded libs is version 1.0.0.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_AddLanguage">AddLanguage</a></td><td>
Adds a language attribute to the internal element. If this is the first language attribute, a simple attribute is added. If this is not the first, a language attribute list is used. A former created simple attribute is transferred to a list item.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_AutomationMLBPRInterfaceClassLib">AutomationMLBPRInterfaceClassLib</a></td><td>
Gets the AutomationMLBPRInterfaceClassLib containing all interface classes used to model external document references to the AMLDocument.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_AutomationMLBPRRoleClassLib">AutomationMLBPRRoleClassLib</a></td><td>
Gets the AutomationMLBPRRoleClassLib containing all role classes used to model external document references to the AMLDocument.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_DocumentElements">DocumentElements</a></td><td>
Gets all Internal Element Children from the specified internal element which are document elements.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataReferenceInterfaceClass">ExternalDataReferenceInterfaceClass(CAEXFileType)</a></td><td>
Gets the 'ExternalDataReference' InterfaceClass from the AML document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataReferenceInterfaceClass_1">ExternalDataReferenceInterfaceClass(InterfaceClassLibType)</a></td><td>
Gets the ExternalDataReference InterfaceClass from the AutomationMLBPRInterfaceClassLib.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClass">ExternalDataRoleClass(CAEXFileType)</a></td><td>
Gets the ExternalData RoleClass from the AML document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClass_1">ExternalDataRoleClass(RoleClassLibType)</a></td><td>
Gets the 'ExternalData' RoleClass from the AutomationMLBPRRoleClassLib.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_GetLanguages">GetLanguages</a></td><td>
Gets the languages, defined for the document element. If the given internal element is not a document element, the collection is empty.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ExternalDataReference_IsDocumentElement">IsDocumentElement</a></td><td>
Determines whether the specified internal element is a document element.</td></tr></table>&nbsp;
<a href="#externaldatareference-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_ExternalDataReference_AutomationMLBPRInterfaceClassLibName">AutomationMLBPRInterfaceClassLibName</a></td><td>
The name of the library containing interface classes specified in BPR documents</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_ExternalDataReference_AutomationMLBPRRoleClassLibName">AutomationMLBPRRoleClassLibName</a></td><td>
The name of the library containing role classes specified in BPR documents</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataReferenceInterfaceClassName">ExternalDataReferenceInterfaceClassName</a></td><td>
The name for the ExternalDataReference interface class</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataReferenceInterfaceClassPath">ExternalDataReferenceInterfaceClassPath</a></td><td>
The class path for the ExternalDataReference interface class</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClassName">ExternalDataRoleClassName</a></td><td>
The name for the ExternalData role class</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_ExternalDataReference_ExternalDataRoleClassPath">ExternalDataRoleClassPath</a></td><td>
The class path for the ExternalData role class</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_AmlObjects_ExternalDataReference_LanguageAttributeName">LanguageAttributeName</a></td><td>
The language attribute name</td></tr></table>&nbsp;
<a href="#externaldatareference-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />