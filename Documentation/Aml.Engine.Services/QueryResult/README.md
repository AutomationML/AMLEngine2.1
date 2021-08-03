QueryResult Class
=================
This class supports the interpretation of the queryResult table which is the result of some queries, defined in [IQuery][1]


Inheritance Hierarchy
---------------------
[System.Object][2]  
  **Aml.Engine.Services.QueryResult**  

  **Namespace:**  [Aml.Engine.Services][3]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class QueryResult
```

The **QueryResult** type exposes the following members.


Methods
-------

                                 | Name                                    | Description                                                                                                                                                                         
-------------------------------- | --------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [AllCaexObjects][4]                     | Gets the CAEX objects from the query result.                                                                                                                                        
![Public method]![Static member] | [AllElementsIdentifiedByCAEXPath][5]    | Gets all the elements which are identifiable by a CAEX path. Elements having the same path are grouped together. Use this method to validate the existence of not unique CAEXPaths. 
![Public method]![Static member] | [AllElementsWithAliasReference][6]      | Gets all the elements with an alias reference. Elements referencing the same Alias are grouped together. Use this method to validate the existence of referenced externals.         
![Public method]![Static member] | [AllElementsWithCAEXPathReference][7]   | Gets all the elements with a path reference. Elements referencing the same path are grouped together. Use this method to validate the existence of referenced classes.              
![Public method]![Static member] | [AllElementsWithIDReference][8]         | Gets all the elements with identifier references. Elements referencing the same ID are grouped together. Use this method to validate the existence of referenced IDs.               
![Public method]![Static member] | [AllElementsWithIDs][9]                 | Gets all the elements with IDs. Elements using the same ID are grouped together. Use this method to validate the uniqueness of IDs.                                                 
![Public method]![Static member] | [AllElementsWithNameReference][10]      | Gets all the elements with a name reference. Elements referencing the same name are grouped together. Use this method to validate the existence of referenced elements.             
![Public method]![Static member] | [AllInternalElementMasters][11]         | Gets all InternalElement objects from the document which are masters.                                                                                                               
![Public method]![Static member] | [AllInternalElementMirrors][12]         | Gets all InternalElement objects from the document which are mirrors.                                                                                                               
![Public method]![Static member] | [CaexObjectsOfType&lt;T>][13]           | Gets the CAEX objects of the specified type from the query result.                                                                                                                  
![Public method]![Static member] | [ElementsWithAliasReference][14]        | Gets alls the elements from the document which use the provided Alias in a reference                                                                                                
![Public method]![Static member] | [ElementsWithCAEXPathReference][15]     | Gets alls the elements from the document which have a reference to the provided Path.                                                                                               
![Public method]![Static member] | [ElementsWithIDReference][16]           | Gets alls the elements from the document which have a reference to the provided ID.                                                                                                 
![Public method]![Static member] | [ElementsWithInternalLinkRelations][17] | Returns all InternalElements and SystemUnitClasses in the defined Document, which are related to others via InternalLinks.                                                          
![Public method]![Static member] | [ExternalInterfaces][18]                | Gets the ExternalInterface objects from the query result.                                                                                                                           
![Public method]![Static member] | [InternalElementMirrors][19]            | Returns all Mirrors of the specified InternalElement.                                                                                                                               
![Public method]![Static member] | [InternalElements][20]                  | Gets the InternalElement objects from the query result.                                                                                                                             
![Public method]![Static member] | [InternalLinks][21]                     | Gets the InternalLink objects from the query result.                                                                                                                                
![Public method]![Static member] | [InternalLinksToElement][22]            | Gets all InternalLink referencing the provided SystemUnitClass object.                                                                                                              
![Public method]![Static member] | [InternalLinksToInterface][23]          | Gets all InternalLinks that reference the specified ExternalInterface.                                                                                                              
![Public method]![Static member] | [ReferencesWithName][24]                | Gets all the references with the provided name from the query result.                                                                                                               


See Also
--------

#### Reference
[Aml.Engine.Services Namespace][3]  

[1]: ../../Aml.Engine.Services.Interfaces/IQuery/README.md
[2]: https://docs.microsoft.com/dotnet/api/system.object
[3]: ../README.md
[4]: AllCaexObjects.md
[5]: AllElementsIdentifiedByCAEXPath.md
[6]: AllElementsWithAliasReference.md
[7]: AllElementsWithCAEXPathReference.md
[8]: AllElementsWithIDReference.md
[9]: AllElementsWithIDs.md
[10]: AllElementsWithNameReference.md
[11]: AllInternalElementMasters.md
[12]: AllInternalElementMirrors.md
[13]: CaexObjectsOfType__1.md
[14]: ElementsWithAliasReference.md
[15]: ElementsWithCAEXPathReference.md
[16]: ElementsWithIDReference.md
[17]: ElementsWithInternalLinkRelations.md
[18]: ExternalInterfaces.md
[19]: InternalElementMirrors.md
[20]: InternalElements.md
[21]: InternalLinks.md
[22]: InternalLinksToElement.md
[23]: InternalLinksToInterface.md
[24]: ReferencesWithName.md
[25]: https://www.automationml.org
[26]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"