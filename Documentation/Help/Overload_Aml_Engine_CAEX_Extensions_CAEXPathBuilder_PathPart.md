# CAEXPathBuilder.PathPart Method 
AutomationML 2.1 API 


## Overload List
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPart_1">PathPart(XElement, Boolean)</a></td><td>
transforms the name of the defined element to a path Part (special characters are escaped).</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPart">PathPart(CAEXObject, Boolean)</a></td><td>
Builds the Path Part for any CAEXObject, which may be part of a CAEX Path. The Path Part is build from the object Names and the Part - Syntax, according to chapter 2.8 of the CAEX guide: If defined separators are potentially a valid part of object names, the following syntax shall be used: all path elements shall be separated by square brackets “[“ name “]”. This allows for using the original names and the defined separators at the same time. If the conflict case arises that the described brackets are part of object names, the brackets in the object name shall be escaped by means of common XML escape-sequences. If a name contains any Path part - Separator like '[' or ]' this character will be escaped with '\'.</td></tr></table>&nbsp;
<a href="#caexpathbuilder.pathpart-method">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder Class</a><br /><a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />