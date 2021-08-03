# SystemUnitFamilyType.HasRoleClassReference Method 
AutomationML 2.1 API 


## Overload List
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitFamilyType_HasRoleClassReference_1">HasRoleClassReference(String, Boolean)</a></td><td>
Determines whether this SystemUnitClass object has a SupportedRoleClass with the specified CAEX path reference. If inheritance relation should be regarded, the optional parameter 'regardInheritance' should be set.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_SystemUnitFamilyType_HasRoleClassReference">HasRoleClassReference(RoleFamilyType, Boolean)</a></td><td>
Determines whether this SystemUnitClass object has a SupportedRoleClass with a reference to the specified RoleClass. If inheritance relations between role classes should be regarded, the optional parameter 'regardInheritance' should be set. In this case the specified RoleClass is either identical to a referenced RoleClass or a referenced RoleClass is derived from the specified RoleClass. Independently of the *regardInheritanceOfRoleClasses* value, always the Role assignments to this SystemUnitClass and any ancestors of this SystemUnitClass are checked, using the <a href="M_Aml_Engine_CAEX_SystemUnitFamilyType_GetInheritedSupportedRoles">GetInheritedSupportedRoles()</a> method.</td></tr></table>&nbsp;
<a href="#systemunitfamilytype.hasroleclassreference-method">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_SystemUnitFamilyType">SystemUnitFamilyType Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />