# CaexValue Properties
AutomationML 2.1 API 

The <a href="T_Aml_Engine_CAEX_Extensions_CaexValue">CaexValue</a> type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Extensions_CaexValue_DefaultValue">DefaultValue</a></td><td>
Gets a default decoded value according to the defined AttributeDataType</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Extensions_CaexValue_FriendlyValueString">FriendlyValueString</a></td><td>
Gets a friendly string of the Attribute value. This string is not in any case equal to the attribute value string, which is always an encoded string, according to the AttributeDataType. The conversion format used to convert the value to its string representation is fix and cannot be changed.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Extensions_CaexValue_TypeAttribute">TypeAttribute</a></td><td>
Gets the Attribute, which defines the AttributeDataType.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Extensions_CaexValue_TypeCodeOfAttribute">TypeCodeOfAttribute</a></td><td>
Gets the .NET Type code which is converted from the XSD Schema attribute defined in the <a href="P_Aml_Engine_CAEX_Extensions_CaexValue_TypeAttribute">TypeAttribute</a>.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Extensions_CaexValue_Value">Value</a></td><td>
Gets and sets the value attribute using the type specific XML conversion method. If no AttributeDataType is defined, the value is encoded / decoded as it is.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_Extensions_CaexValue_ValueElement">ValueElement</a></td><td>
Gets the Element, which contains the Attribute value.</td></tr></table>&nbsp;
<a href="#caexvalue-properties">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CaexValue">CaexValue Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />