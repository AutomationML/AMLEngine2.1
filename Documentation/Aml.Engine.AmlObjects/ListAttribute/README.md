ListAttribute Class
===================
Class ListAttribute supports List Attributes as it is defined in the BPR 'Modelling of List Attributes in AutomationML' from January 2016 Version 1.0.0


Inheritance Hierarchy
---------------------
[System.Object][1]  
  **Aml.Engine.AmlObjects.ListAttribute**  

  **Namespace:**  [Aml.Engine.AmlObjects][2]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static class ListAttribute
```

The **ListAttribute** type exposes the following members.


Methods
-------

                                 | Name                          | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
-------------------------------- | ----------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
![Public method]![Static member] | [AddListItem][3]              | Adds an additional list item attribute to the list attribute. If the List attribute already contains some items, the new item will have the same item type as the already existing items. If this is the first item, the specified itemType is used as the attribute data type. If no itemType is defined, the default data type for the list item is "xs:string". The Item name is automatically set to the Index if the List attribute is an ordered list, otherwise the defined itemName is used. 
![Public method]![Static member] | [ConvertToListAttribute][4]   | Changes the semantic of the specified attribute and converts to a list attribute. A first item is added to the List attribute which is initialized with valued from the converted attribute. If the Attribute is already a list attribute or the attribute contains child attributes it will not be converted.                                                                                                                                                                                       
![Public method]![Static member] | [CreateListAttribute][5]      | Creates a new list attribute for an element which can have attributes.                                                                                                                                                                                                                                                                                                                                                                                                                               
![Public method]![Static member] | [IsListAttribute][6]          | Determines whether the specified attribute is a list attribute. This can be ordered or unordered.                                                                                                                                                                                                                                                                                                                                                                                                    
![Public method]![Static member] | [IsOrderedListAttribute][7]   | Determines whether the specified attribute is an ordered list attribute.                                                                                                                                                                                                                                                                                                                                                                                                                             
![Public method]![Static member] | [IsUnOrderedListAttribute][8] | Determines whether the specified attribute is an unordered list attribute.                                                                                                                                                                                                                                                                                                                                                                                                                           
![Public method]![Static member] | [ListItems][9]                | Gets the values of all items in the list attribute                                                                                                                                                                                                                                                                                                                                                                                                                                                   
![Public method]![Static member] | [ListItemValues][10]          | Gets the values of all items in the list attribute                                                                                                                                                                                                                                                                                                                                                                                                                                                   
![Public method]![Static member] | [MakeListAttribute][11]       | Changes the semantic of the specified attribute and converts it to a list attribute. If the Attribute is already a list attribute or the attribute contains child attributes it will not be converted.                                                                                                                                                                                                                                                                                               


Fields
------

                                | Name                      | Description                                                                  
------------------------------- | ------------------------- | ---------------------------------------------------------------------------- 
![Public field]![Static member] | [ListTypeName][12]        | The list type name used as a semantic ref type for unordered list attributes 
![Public field]![Static member] | [OrderedListTypeName][13] | The list type name used as a semantic ref type for ordered list attributes   


See Also
--------

#### Reference
[Aml.Engine.AmlObjects Namespace][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: ../README.md
[3]: AddListItem.md
[4]: ConvertToListAttribute.md
[5]: CreateListAttribute.md
[6]: IsListAttribute.md
[7]: IsOrderedListAttribute.md
[8]: IsUnOrderedListAttribute.md
[9]: ListItems.md
[10]: ListItemValues.md
[11]: MakeListAttribute.md
[12]: ListTypeName.md
[13]: OrderedListTypeName.md
[14]: https://www.automationml.org
[15]: ../../icons/logoShade.png
[Public method]: ../../icons/pubmethod.gif "Public method"
[Static member]: ../../icons/static.gif "Static member"
[Public field]: ../../icons/pubfield.gif "Public field"