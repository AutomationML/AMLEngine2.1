Aml.Engine.Schema Namespace
===========================
AutomationML 2.1 APIThe Aml.Engine.Schema Namespace contains a schema parser which is used to parse the document assigned CAEX schema. All changes made to a document with API methods are supported by a schema specific schema manager which assures, that all insertions and changes are schema conform. Currently schema managers exist for CAEX version 2.15, which is [AMLSchemaManager2_15][1] and CAEX version 3.0, which is [AMLSchemaManager3_0][2]. The schema managers are made public to supply methods for schema conform CAEX document processing capabilities to users who don't like to use the API wrapper-classes and methods.


Classes
-------

                | Class                      | Description                                                                                                                                                                                                                                                                                                                                          
--------------- | -------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public class] | [AMLSchemaManager][3]      | Class AMLSchemaManager extends the XMLSchemaManager. Methods which create new objects are overridden to add required properties and values to some objects which is not defined in the underlying CAEX schema but in the AML standard.                                                                                                               
![Public class] | [AMLSchemaManager2_15][1]  | Singleton Class: Schema manager for CAEX-Schema Version 2.15 used in AutomationML                                                                                                                                                                                                                                                                    
![Public class] | [AMLSchemaManager3_0][2]   | Singleton Class: Schema manager for CAEX-Schema Version 3.0 used in AutomationML                                                                                                                                                                                                                                                                     
![Public class] | [XmlSchemaElementInfo][4]  | This class defined methods and properties to access schema information for a schema element.                                                                                                                                                                                                                                                         
![Public class] | [XmlSchemaManager][5]      | Class supports the creation of schema conform xml documents for a given schema. It can be used to create elements with all required attributes and child elements and default values associated. Insertion of new child elements for a given parent at a schema is supported, guaranteeing schema conform sequences and occurrences of all children. 
![Public class] | [XmlTypeCodeExtensions][6] | This static class provides extension methods for the interpretation of [XmlTypeCode][7].                                                                                                                                                                                                                                                             

[1]: AMLSchemaManager2_15/README.md
[2]: AMLSchemaManager3_0/README.md
[3]: AMLSchemaManager/README.md
[4]: XmlSchemaElementInfo/README.md
[5]: XmlSchemaManager/README.md
[6]: XmlTypeCodeExtensions/README.md
[7]: https://docs.microsoft.com/dotnet/api/system.xml.schema.xmltypecode
[8]: https://www.automationml.org
[9]: ../icons/logoShade.png
[Public class]: ../icons/pubclass.gif "Public class"