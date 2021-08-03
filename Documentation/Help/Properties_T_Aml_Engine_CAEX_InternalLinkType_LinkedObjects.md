# LinkedObjects Properties
AutomationML 2.1 API 

The <a href="T_Aml_Engine_CAEX_InternalLinkType_LinkedObjects">InternalLinkType.LinkedObjects</a> type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_InternalLinkType_LinkedObjects_AInterface">AInterface</a></td><td>
Gets the A-Interface of the InternalLink by interpretation of the <a href="P_Aml_Engine_CAEX_InternalLinkType_RefPartnerSideA">RefPartnerSideA</a> Attribute on first access. Consecutive reads will return the at first calculated value. A Reinterpretation is performed, when the respective InternalLink property <a href="P_Aml_Engine_CAEX_InternalLinkType_AInterface">AInterface</a> is read or set.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_InternalLinkType_LinkedObjects_ASystemUnitClass">ASystemUnitClass</a></td><td>
Gets the A-SystemUnitClass using the preserved value <a href="P_Aml_Engine_CAEX_InternalLinkType_LinkedObjects_AInterface">AInterface</a>. If this value has not been calculated, a recalculation is performed.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_InternalLinkType_LinkedObjects_BInterface">BInterface</a></td><td>
Gets the B-Interface of the InternalLink by interpretation of the <a href="P_Aml_Engine_CAEX_InternalLinkType_RefPartnerSideB">RefPartnerSideB</a> Attribute on first access. Consecutive reads will return the at first calculated value. A Reinterpretation is performed, when the respective InternalLink property <a href="P_Aml_Engine_CAEX_InternalLinkType_BInterface">BInterface</a> is read or set.</td></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_InternalLinkType_LinkedObjects_BSystemUnitClass">BSystemUnitClass</a></td><td>
Gets the B-SystemUnitClass using the preserved value <a href="P_Aml_Engine_CAEX_InternalLinkType_LinkedObjects_BInterface">BInterface</a>. If this value has not been calculated, a recalculation is performed.</td></tr></table>&nbsp;
<a href="#linkedobjects-properties">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalLinkType_LinkedObjects">InternalLinkType.LinkedObjects Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />