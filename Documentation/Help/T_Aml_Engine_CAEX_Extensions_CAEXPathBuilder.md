# CAEXPathBuilder Class
AutomationML 2.1 API 

Static class supporting the generation and analysis of CAEXPath's


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.CAEX.Extensions.CAEXPathBuilder<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class CAEXPathBuilder
```

**VB**<br />
``` VB
Public NotInheritable Class CAEXPathBuilder
```

**C++**<br />
``` C++
public ref class CAEXPathBuilder abstract sealed
```

The CAEXPathBuilder type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_AliasFromReference">AliasFromReference</a></td><td>
Gets the alias name from a reference. If the reference is not a reference with an alias, the return value is string.Empty.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_CAEXPath_1">CAEXPath(IEnumerable(XElement))</a></td><td>
Builds the Reference-Path which includes all Names of CAEXObjects in the given list of elements.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_CAEXPath">CAEXPath(IEnumerable(CAEXObject))</a></td><td>
Builds the Reference-Path which includes all Names of CAEXObjects in the given list of CAEX objects.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_CAEXPath_2">CAEXPath(String[], CAEXDocument.CAEXSchema)</a></td><td>
Builds the Reference-Path which includes all names of CAEX objects in the given name array.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_CanNormalize">CanNormalize</a></td><td>
Determines whether the specified path can be normalized because it contains path part delimiters</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_ContainsPathSeparatorChars">ContainsPathSeparatorChars</a></td><td>
Determines whether the specified name contains path separator chars.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_ExternalInterfaceIDInAttributeReference">ExternalInterfaceIDInAttributeReference</a></td><td>
Check, if the provided reference is a reference to an attribute of an ExternalInterface, using the ID of an ExternalInterface.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_InstanceIDInAttributeReference">InstanceIDInAttributeReference</a></td><td>
Gets the ID of the master parent instance from a reference defined in an Attribute mirror object in the specified CAEX document.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_InternalElementIDInInternalLinkReference">InternalElementIDInInternalLinkReference</a></td><td>
Gets the InternalElement ID from a reference defined in an InternalLink object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_InternalLinkReferencePath_1">InternalLinkReferencePath(XElement, XElement)</a></td><td>
gets the reference path for an Interface-Reference in an InternalLink</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_InternalLinkReferencePath">InternalLinkReferencePath(SystemUnitClassType, InterfaceClassType)</a></td><td>
Builds the reference Path for an Interface-Reference in an InternalLink</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_IsAlias">IsAlias</a></td><td>
Determines whether the specified part of a path is an alias.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_IsAttributeReference">IsAttributeReference</a></td><td>
Determines, if the path is an Attribute reference. This method is able to distinguish if an UUID is combined with a CAEX path</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_IsIDReferenceWithAlias">IsIDReferenceWithAlias</a></td><td>
Determines whether the specified object reference is an alias reference to an ID in the specified document</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_IsInterfaceReference">IsInterfaceReference</a></td><td>
Determines, if the path is build using an interface separator. This method is able to distinguish if an interface separator char is used in an interface name and is escaped</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_IsObjectReferenceWithAlias">IsObjectReferenceWithAlias</a></td><td>
Determines whether the specified classReference is an alias reference to the provided AutomationML class path.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_IsReferenceWithAlias">IsReferenceWithAlias</a></td><td>
Determines whether the specified reference is defined with an alias separator.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_IsValidAttributeReferenceID">IsValidAttributeReferenceID</a></td><td>
Determines whether the ID is valid to be used in an attribute mirror reference.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_IsValidID">IsValidID</a></td><td>
Determines whether the specified string can represent an ID</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_NormalizePath">NormalizePath</a></td><td>
Normalization of a CAEXPath. A normalized path is freed of all path part delimiters '[' and ']' in case that there is no path part name containing a path separator character like '/'.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathNameArray">PathNameArray</a></td><td>
Returns the Path Part object names of a CAEX Path. If any object name contains a path separator character the path part is enclosed in square brackets '[', ']'. The square brackets are removed from the object name in the returned result (default behaviour). If keepPathPartBrackets is set to true, square brackets are not removed.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathNameArrayWithSeparator">PathNameArrayWithSeparator</a></td><td>
Returns the Path Part object names of a CAEX Path with the Separator Char at the Names End as an array of strings.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathNameListWithSeparator">PathNameListWithSeparator</a></td><td>
Returns the Path Part object names of a CAEX Path with the Separator Char at the Names End as an array of strings.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPart_1">PathPart(XElement, Boolean)</a></td><td>
transforms the name of the defined element to a path Part (special characters are escaped).</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPart">PathPart(CAEXObject, Boolean)</a></td><td>
Builds the Path Part for any CAEXObject, which may be part of a CAEX Path. The Path Part is build from the object Names and the Part - Syntax, according to chapter 2.8 of the CAEX guide: If defined separators are potentially a valid part of object names, the following syntax shall be used: all path elements shall be separated by square brackets “[“ name “]”. This allows for using the original names and the defined separators at the same time. If the conflict case arises that the described brackets are part of object names, the brackets in the object name shall be escaped by means of common XML escape-sequences. If a name contains any Path part - Separator like '[' or ]' this character will be escaped with '\'.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPartName">PathPartName</a></td><td>
Transforms a name to a path Part (special characters are escaped).</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPartObjectNames">PathPartObjectNames</a></td><td>
Returns the Path Part object names of a CAEX Path. If any object name contains a path separator character the path part is enclosed in square brackets '[', ']'. The square brackets are removed from the object name in the returned result (default behaviour). If keepPathPartBrackets is set to true, square brackets are not removed.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPartObjectNamesWithSeparator">PathPartObjectNamesWithSeparator</a></td><td>
Returns the Path Part object names of a CAEX Path with the Separator Char at the Names End</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPartSeparator_1">PathPartSeparator(XElement)</a></td><td>
Returns the Path part separator for an element, which should be put before that element in a Path</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPartSeparator">PathPartSeparator(CAEXObject)</a></td><td>
Returns the Path part separator for an element, which should be put before that element in a Path</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_RemoveAlias">RemoveAlias</a></td><td>
Removes the alias from the provided path if the path is <a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_IsReferenceWithAlias">IsReferenceWithAlias(String, CAEXDocument.CAEXSchema)</a>.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_SeparatorChars">SeparatorChars</a></td><td>
Gets the defined Separator characters according to the provided schema version.</td></tr></table>&nbsp;
<a href="#caexpathbuilder-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_AliasSeparator">AliasSeparator</a></td><td>
The alias separator used after Alias</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_AttributeSeparator">AttributeSeparator</a></td><td>
The attribute separator used before attribute hierarchies.</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_InterfaceSeparator">InterfaceSeparator</a></td><td>
The interface separator used before an interface</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_ObjectSeparator">ObjectSeparator</a></td><td>
The object separator used between object hierarchies</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPartBegin">PathPartBegin</a></td><td>
The begin of a path part, used if the object name contains a Path Separator</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPartBeginInName">PathPartBeginInName</a></td><td>
The escaped <a href="F_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPartBegin">PathPartBegin</a>, used in an object name, if it contains this character</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPartEnd">PathPartEnd</a></td><td>
The end of a path part, used if the object name contains a Path Separator</td></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPartEndInName">PathPartEndInName</a></td><td>
The escaped <a href="F_Aml_Engine_CAEX_Extensions_CAEXPathBuilder_PathPartEnd">PathPartEnd</a>, used in an object name, if it contains this character</td></tr></table>&nbsp;
<a href="#caexpathbuilder-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX_Extensions">Aml.Engine.CAEX.Extensions Namespace</a><br />