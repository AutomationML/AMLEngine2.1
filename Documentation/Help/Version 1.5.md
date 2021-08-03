# AMLEngine2.1 Version 1.5

Version 1.5 of AMLEngine2.1 was released in January 2021. The actual service release is Version 1.5.76.


Support of .NET Framework 4.6 and .NET core 2.1 is no longer provided with this version. Support for .NET 5 and .NET core 3.1 is provided now.



## New in Version 1.5
&nbsp;<ul><li>
AMLContainer provides a new method <a href="M_Aml_Engine_AmlObjects_AutomationMLContainer_RelinkPart">RelinkPart</a> changes the uri of a package part. The part is removed and readded with the provided new uri. All relationships of the part are updated..</li><li>
New method in SystemUnitFamilyType <a href="Overload_Aml_Engine_CAEX_SystemUnitFamilyType_HasGenericRoleClassReference">HasGenericRoleClassReference</a> allows to check supported role requirements.</li><li>
New properties to access attribute values are added, which support encoding and decoding the XML strings to .NET types when the Attributes datatype is defined. The Properties are defined as <a href="P_Aml_Engine_CAEX_AttributeTypeType_AttributeValue">AttributeValue</a> and <a href="P_Aml_Engine_CAEX_AttributeTypeType_DefaultAttributeValue">DefaultAttributeValue</a></li><li>
New optional behavior added to the <a href="Overload_Aml_Engine_CAEX_InternalElementType_AddRoleClassReference">AddRoleClassReference</a> method and overloads allowing to add a full RoleClass instance, containing all ExternalInterfaces and Attributes of the RoleClass. A new equivalent method AddInterfaceClassReference has been defined.</li><li>
A new overload of <a href="Overload_Aml_Engine_CAEX_Extensions_SystemUnitClassTypeExtensions_New_ExternalInterface">New_ExternalInterface</a>provides an additional parameter to define the referenced class path.</li></ul>

## See Also


#### Other Resources
<a href="Version history">Version History</a><br />