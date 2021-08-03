# ObjectWithAttributes Class
AutomationML 2.1 API 

Extension methods for all objects with Attribute collections.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.CAEX.Extensions.ObjectWithAttributes<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class ObjectWithAttributes
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public NotInheritable Class ObjectWithAttributes
```

**C++**<br />
``` C++
[ExtensionAttribute]
public ref class ObjectWithAttributes abstract sealed
```

The ObjectWithAttributes type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_AddAttributeTypeReference">AddAttributeTypeReference(IObjectWithAttributes, AttributeFamilyType, Boolean, Boolean, String)</a></td><td>
Adds an AttributeType reference to this ObjectWithAttribute using the provided AttributeType object. The AttributeType reference is added as a <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a> object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")![Code example](media/CodeExample.png "Code example")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_AddAttributeTypeReference_1">AddAttributeTypeReference(IObjectWithAttributes, String, Boolean, Boolean, String)</a></td><td>
Adds an AttributeType reference to this ObjectWithAttribute using the provided CAEX path, referencing an AttributeType object. The AttributeType reference is added as a <a href="T_Aml_Engine_CAEX_AttributeType">AttributeType</a> object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_CopyAttributesFrom">CopyAttributesFrom</a></td><td>
Copies all attribute of the source object with attributes to the target object including children</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_GetAttribute">GetAttribute</a></td><td> **Obsolete. **
Gets the first attribute with the specified name from the attribute collection of the CAEX object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_New_Attribute">New_Attribute</a></td><td>
Appends a new Attribute object with the defined name to the specified CAEX object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_SetAttributeValue">SetAttributeValue(IObjectWithAttributes, String, Double)</a></td><td>
Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_SetAttributeValue_2">SetAttributeValue(IObjectWithAttributes, String, String)</a></td><td>
Sets the value for the attribute with the specified name from the attribute collection of the CAEX object. If no attribute with that name exists, it is created.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_SetAttributeValue_3">SetAttributeValue(IObjectWithAttributes, String, String, String, String)</a></td><td>
Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_SetAttributeValue_1">SetAttributeValue(IObjectWithAttributes, String, Double, Double, String, String)</a></td><td>
Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created. Sets the AttributeDataType to xs:double</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_ObjectWithAttributes_SetAttributeValue_4">SetAttributeValue(IObjectWithAttributes, String, String, String, String, String, String)</a></td><td>
Modifies the attribute with the specified name from the attribute collection of the CAEX object, using the provided values. If no attribute with that name exists, it is created.</td></tr></table>&nbsp;
<a href="#objectwithattributes-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />