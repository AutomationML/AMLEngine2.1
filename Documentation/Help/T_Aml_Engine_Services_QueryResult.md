# QueryResult Class
AutomationML 2.1 API 

This class supports the interpretation of the queryResult table which is the result of some queries, defined in <a href="T_Aml_Engine_Services_Interfaces_IQuery">IQuery</a>


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;Aml.Engine.Services.QueryResult<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static class QueryResult
```

**VB**<br />
``` VB
<ExtensionAttribute>
Public NotInheritable Class QueryResult
```

**C++**<br />
``` C++
[ExtensionAttribute]
public ref class QueryResult abstract sealed
```

The QueryResult type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllCaexObjects">AllCaexObjects</a></td><td>
Gets the CAEX objects from the query result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllElementsIdentifiedByCAEXPath">AllElementsIdentifiedByCAEXPath</a></td><td>
Gets all the elements which are identifiable by a CAEX path. Elements having the same path are grouped together. Use this method to validate the existence of not unique CAEXPaths.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllElementsWithAliasReference">AllElementsWithAliasReference</a></td><td>
Gets all the elements with an alias reference. Elements referencing the same Alias are grouped together. Use this method to validate the existence of referenced externals.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllElementsWithCAEXPathReference">AllElementsWithCAEXPathReference</a></td><td>
Gets all the elements with a path reference. Elements referencing the same path are grouped together. Use this method to validate the existence of referenced classes.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllElementsWithIDReference">AllElementsWithIDReference</a></td><td>
Gets all the elements with identifier references. Elements referencing the same ID are grouped together. Use this method to validate the existence of referenced IDs.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllElementsWithIDs">AllElementsWithIDs</a></td><td>
Gets all the elements with IDs. Elements using the same ID are grouped together. Use this method to validate the uniqueness of IDs.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllElementsWithNameReference">AllElementsWithNameReference</a></td><td>
Gets all the elements with a name reference. Elements referencing the same name are grouped together. Use this method to validate the existence of referenced elements.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllInternalElementMasters">AllInternalElementMasters</a></td><td>
Gets all InternalElement objects from the document which are masters.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_AllInternalElementMirrors">AllInternalElementMirrors</a></td><td>
Gets all InternalElement objects from the document which are mirrors.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_CaexObjectsOfType__1">CaexObjectsOfType(T)</a></td><td>
Gets the CAEX objects of the specified type from the query result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_ElementsWithAliasReference">ElementsWithAliasReference</a></td><td>
Gets alls the elements from the document which use the provided Alias in a reference</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_ElementsWithCAEXPathReference">ElementsWithCAEXPathReference</a></td><td>
Gets alls the elements from the document which have a reference to the provided Path.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_ElementsWithIDReference">ElementsWithIDReference</a></td><td>
Gets alls the elements from the document which have a reference to the provided ID.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_ElementsWithInternalLinkRelations">ElementsWithInternalLinkRelations</a></td><td>
Returns all InternalElements and SystemUnitClasses in the defined Document, which are related to others via InternalLinks.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_ExternalInterfaces">ExternalInterfaces</a></td><td>
Gets the ExternalInterface objects from the query result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_InternalElementMirrors">InternalElementMirrors</a></td><td>
Returns all Mirrors of the specified InternalElement.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_InternalElements">InternalElements</a></td><td>
Gets the InternalElement objects from the query result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_InternalLinks">InternalLinks</a></td><td>
Gets the InternalLink objects from the query result.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_InternalLinksToElement">InternalLinksToElement</a></td><td>
Gets all InternalLink referencing the provided SystemUnitClass object.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_InternalLinksToInterface">InternalLinksToInterface</a></td><td>
Gets all InternalLinks that reference the specified ExternalInterface.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_Services_QueryResult_ReferencesWithName">ReferencesWithName</a></td><td>
Gets all the references with the provided name from the query result.</td></tr></table>&nbsp;
<a href="#queryresult-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />