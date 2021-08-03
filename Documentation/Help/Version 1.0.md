# AMLEngine2.1 Version 1.0

Version 1.0 of AMLEngine2.1 was released on 01.01.2018. The actual service release is Version 1.0.7.



## Advances in Version 1.0

This Version of the AMLEngine is an advanced development of the AMLEngine Version 3.x which only supports AutomationML Version 2.0 and the CAEX Version 2.15. This new development also supports **AutomationML Version 2.10** which is based on **CAEX Version 3.0**. This AMLEngine is not based on code generation from the ALTOVA tool suite and has no dependencies to Altova DLLs. Instead all XML processing is based on the .NET LINQ to XML integrated query framework. To ease adaption of legacy code to this advanced version of the AMLEngine a special adapter package is provided. Not all features from the former AMLEngine based on Altova code generation are adaptable, especially the data types and classes which were defined by Altova are not supported. There also exist many methods which are marked as obsolete, because they are either redundant or replaced by methods, implementing simpler access patterns.
&nbsp;<ul><li>
Support for AutomationML 2.10 and CAEX 3.0
&nbsp;<ul><li>
New AttributeType Library: <a href="T_Aml_Engine_CAEX_AttributeTypeLibType">AttributeTypeLibType</a></li><li>
New AttributeType Library content element, named AttributeFamilyType: <a href="T_Aml_Engine_CAEX_AttributeFamilyType">AttributeFamilyType</a></li><li>
New defined instance class relations from Attributes to AttributeTypes, named RefAttributeType, see <a href="P_Aml_Engine_CAEX_AttributeFamilyType_RefAttributeType">RefAttributeType</a> and <a href="P_Aml_Engine_CAEX_AttributeType_AttributeTypeReference">AttributeTypeReference</a>.</li><li>
Multiple RoleRequirements can be associated to an InternalElment: <a href="P_Aml_Engine_CAEX_InternalElementType_RoleRequirements">RoleRequirements</a></li><li>
MappingObject moved from InternalElement to RoleRequirements: <a href="P_Aml_Engine_CAEX_RoleRequirementsType_MappingObject">MappingObject</a></li><li>
InterfaceNameMapping replaced with new InterfaceIDMapping: <a href="T_Aml_Engine_CAEX_InterfaceIDMappingType">InterfaceIDMappingType</a></li></ul></li><li>
Additional specific features have been moved to the new namespace <a href="N_Aml_Engine_Services">Aml.Engine.Services</a>
&nbsp;<ul><li>
New ServiceLocator for service registration and service location: <a href="T_Aml_Engine_Services_ServiceLocator">ServiceLocator</a></li><li>
Queries for navigation and fast access to elements are provided from new query services.
&nbsp;<ul style="list-style-type: none; padding-left: 20px;"><li>
Query service for fast lookup of CAEX objects using ID- and CAEX path tables. <a href="T_Aml_Engine_Services_LookupService">LookupService</a></li><li>
Default query service. This service is used, when no other query service is registered. <a href="T_Aml_Engine_Services_QueryService">QueryService</a></li></ul></li><li>
Document validation is provided by a new Validator service: <a href="T_Aml_Engine_Services_ValidatorService">ValidatorService</a>.</li><li>
Splitting of documents is provided by a new Split service: <a href="T_Aml_Engine_Services_SplitService">SplitService</a>.</li><li>
Merging of documents is provided by a new Merge service: <a href="T_Aml_Engine_Services_MergeService">MergeService</a>.</li><li>
New service added for schema transformation of documents: <a href="T_Aml_Engine_Services_CAEXSchemaTransformer">CAEXSchemaTransformer</a>.</li><li>
New service added for Undo/Redo: <a href="T_Aml_Engine_Services_UndoRedoService">UndoRedoService</a>.</li><li>
New service added for Unique name generation: <a href="T_Aml_Engine_Services_UniqueNameService">UniqueNameService</a>.</li><li>
New service added to query elements outsourced in ExternalReferences: <a href="T_Aml_Engine_Services_ExternalReferenceResolver">ExternalReferenceResolver</a>.</li></ul></li></ul>

## Service Release 1.0.7

The service release v1.0.7 defines a new namespace <a href="N_Aml_Engine_Adapter">Aml.Engine.Adapter</a> which contains methods, which are adapted versions of the AMLEngine v3.x.x. These methods are marked as obsolete and should only be used for the migration of legacy code, which has been developed base on the AMLEngine v3.x.x. For all methods, alternatives are described. There are still not all methods, available in the former AMLEngine, transfered to the Aml.Engine.Adapter namespace. Further migrations will be available in upcoming versions. If methods are missing, please provide the missing method signatures to the development team.


This service release contains various bug fixes which are listed in the release notes (published with the software).



## See Also


#### Other Resources
<a href="Version history">Version History</a><br />