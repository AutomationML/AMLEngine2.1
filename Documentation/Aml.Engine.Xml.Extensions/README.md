Aml.Engine.Xml.Extensions Namespace
===================================
The Aml.Engine.Xml.Extensions Namespace defines extensions methods for the underlying Xml Elements and Xml Attributes of the CAEX objects. These methods could be applicable in specific use cases but could result in the creation of invalid AutomationML documents, if not applied correctly.


Classes
-------

                | Class              | Description                                                                                                                                                                            
--------------- | ------------------ | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public class] | [XmlCAEXSchema][1] | Class, defining extension methods, related to the interpretation of the Schema version of a CAEX file.                                                                                 
![Public class] | [XmlOperation][2]  | This class defines extension methods for XElements. These methods are useful, if any XElement should be queried for some CAEX properties without using a CAEXWrapper for this element. 

[1]: XmlCAEXSchema/README.md
[2]: XmlOperation/README.md
[3]: https://www.automationml.org
[4]: ../icons/logoShade.png
[Public class]: ../icons/pubclass.gif "Public class"