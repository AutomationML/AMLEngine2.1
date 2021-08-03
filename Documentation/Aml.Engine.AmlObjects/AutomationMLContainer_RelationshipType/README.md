AutomationMLContainer.RelationshipType Class
============================================
Class RelationshipType describes the distinguished package part relationship types. This class cannot be inherited.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.AmlObjects.AutomationMLContainer.RelationshipType**  

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public sealed class RelationshipType : IComparable<AutomationMLContainer.RelationshipType>
```

The **AutomationMLContainer.RelationshipType** type exposes the following members.


Properties
----------

                   | Name          | Description                            
------------------ | ------------- | -------------------------------------- 
![Public property] | [MimeType][3] | Gets the mime type of the relationship 
![Public property] | [Name][4]     | Gets the name of the relationship.     


Methods
-------

                                 | Name               | Description                                                                                                                                                                                                                             
-------------------------------- | ------------------ | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]                 | [CompareTo][5]     | Compares the current instance's name to another object's name of the same type and returns an integer indicating whether the current instance's name occurs in the sort order before or after the other object or at the same position. 
![Public method]![Static member] | [GetAnyContent][6] | Creates a RelationshipType for any content. If no mime type is defined, the relationship type [AnyContent][7] is used.                                                                                                                  
![Public method]                 | [ToString][8]      | Returns the [Name][4] as the string representation of this instance. (Overrides [Object.ToString()][9].)                                                                                                                                


Fields
------

                                | Name                   | Description                                                                                                         
------------------------------- | ---------------------- | ------------------------------------------------------------------------------------------------------------------- 
![Public field]![Static member] | [AnyContent][7]        | relationship type for package to part or root part to part relations to any content.                                
![Public field]![Static member] | [CAEXSchema][10]       | relationship type for package to part relation to the CAEX schema part.                                             
![Public field]![Static member] | [Collada][11]          | relationship type for package to part or root part to part relations to a COLLADA part.                             
![Public field]![Static member] | [ColladaSchema][12]    | relationship type for package to part relation to the COLLADA schema.                                               
![Public field]![Static member] | [Library][13]          | relationship type for package to part or root part to part relations to a part, containing an AutomationML library. 
![Public field]![Static member] | [PLCopenXml][14]       | relationship type for package to part or root part to part relations to a PLCopenXml part.                          
![Public field]![Static member] | [PLCopenXmlSchema][15] | relationship type for package to part relation to the PLCopenXml schema.                                            
![Public field]![Static member] | [Root][16]             | relationship type for the package to part relation to the part containing the root document.                        


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: MimeType.md
[4]: Name.md
[5]: CompareTo.md
[6]: GetAnyContent.md
[7]: AnyContent.md
[8]: ToString.md
[9]: https://docs.microsoft.com/dotnet/api/system.object.tostring#System_Object_ToString
[10]: CAEXSchema.md
[11]: Collada.md
[12]: ColladaSchema.md
[13]: Library.md
[14]: PLCopenXml.md
[15]: PLCopenXmlSchema.md
[16]: Root.md
[17]: https://www.automationml.org
[18]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"
[Public field]: ../../icons/pubfield.gif "Public field"