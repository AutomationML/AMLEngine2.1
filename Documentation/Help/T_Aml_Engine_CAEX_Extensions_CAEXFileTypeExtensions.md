# CAEXFileTypeExtensions Class
AutomationML 2.1 API 

This class defines extension methods for the CAEXFile Element


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.CAEX.Extensions.CAEXFileTypeExtensions<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class CAEXFileTypeExtensions
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public NotInheritable Class CAEXFileTypeExtensions
```

**C++**<br />
``` C++
[ExtensionAttribute]
public ref class CAEXFileTypeExtensions abstract sealed
```

The CAEXFileTypeExtensions type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_FindFastByID">FindFastByID(CAEXFileType, String, Boolean)</a></td><td> **Obsolete. **
Performs a document wide fast search and returns a CAEXObject given by its ID.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_FindFastByID__1">FindFastByID(T)(CAEXFileType, String, Boolean)</a></td><td> **Obsolete. **
Performs a document wide fast search and returns an object of type 'T' given by its ID.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_FindFastByPath">FindFastByPath(CAEXFileType, String, Boolean)</a></td><td> **Obsolete. **
Performs a document wide fast search and returns a CAEXObject given by its Path, e.g. "plant/unit" or -in case the document is based on CAEX 2.15 - "GUID:Interface".</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_FindFastByPath__1">FindFastByPath(T)(CAEXFileType, String, Boolean)</a></td><td> **Obsolete. **
Performs a document wide fast search and returns an object of type 'T' given by its Path, e.g. "plant/unit" or -in case the document is based on CAEX 2.15 - "GUID:Interface".</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_Import_AttributeTypeLib">Import_AttributeTypeLib</a></td><td>
Imports the provided library into the AttributeTypeLib collection of this CAEX file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_Import_InstanceHierarchy">Import_InstanceHierarchy</a></td><td>
Imports the provided source instance hierarchy into the InstanceHierarchy collection of this CAEX file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_Import_InterfaceClassLibHierarchy">Import_InterfaceClassLibHierarchy</a></td><td>
Imports the provided library into the InterfaceClassLib collection of this CAEX file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_Import_RoleClassLibHierarchy">Import_RoleClassLibHierarchy</a></td><td>
Imports the provided library into the RoleClassLib collection of this CAEX file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_Import_SystemUnitClassLibHierarchy">Import_SystemUnitClassLibHierarchy</a></td><td>
Imports the provided library into the SystemUnitClassLib collection of this CAEX file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_Insert_ExternalReference">Insert_ExternalReference</a></td><td> **Obsolete. **
Inserts the ExternalReference into the CAEX file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_Insert_InstanceHierarchy">Insert_InstanceHierarchy</a></td><td> **Obsolete. **
Insert an existing InstanceHierarchy to this CAEX file as the last InstanceHierarchy.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_Insert_InterfaceClassLibHierarchy">Insert_InterfaceClassLibHierarchy</a></td><td> **Obsolete. **
Insert an existing InterfaceClassLib to this CAEX file as the last InterfaceClassLib.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_Insert_RoleClassLibHierarchy">Insert_RoleClassLibHierarchy</a></td><td> **Obsolete. **
Insert a RoleClassLib to this CAEX file as the last RoleClassLib.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_Insert_SystemUnitClassLibHierarchy">Insert_SystemUnitClassLibHierarchy</a></td><td> **Obsolete. **
Append a SystemUnitClassLib to this CAEX file as the last SystemUnitClassLib.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_New_ExternalReference">New_ExternalReference</a></td><td>
A new ExternalReference node is added to the CAEX file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_New_InstanceHierarchy">New_InstanceHierarchy</a></td><td>
Adding a new InstanceHierarchy with the given name to this CAEX file. The Instance Hierarchy is always added as the last Instance Hierarchy.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_New_InterfaceClassLibHierarchy">New_InterfaceClassLibHierarchy</a></td><td>
Adding a new InterfaceClassLib to this CAEX file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_New_RoleClassLibHierarchy">New_RoleClassLibHierarchy</a></td><td>
Adding a new RoleClassLib to this CAEX file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_New_SystemUnitClassLibHierarchy">New_SystemUnitClassLibHierarchy</a></td><td>
Adding a new SystemUnitClassLib to this CAEX file.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXFileTypeExtensions_PreorderTraversal">PreorderTraversal</a></td><td>
Traversal method for a hierarchical tree, with identical childSelector for all tree nodes. The method uses a pre-order algorithm without recursion for the deep traversal of the complete tree.</td></tr></table>&nbsp;
<a href="#caexfiletypeextensions-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />