ListAttribute.AddListItem Method
================================
Adds an additional list item attribute to the list attribute. If the List attribute already contains some items, the new item will have the same item type as the already existing items. If this is the first item, the specified itemType is used as the attribute data type. If no itemType is defined, the default data type for the list item is "xs:string". The Item name is automatically set to the Index if the List attribute is an ordered list, otherwise the defined itemName is used.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static AttributeType AddListItem(
	this AttributeType attribute,
	string itemType = "",
	string itemName = "item"
)
```

#### Parameters

##### *attribute*
Type: [Aml.Engine.CAEX.AttributeType][2]  
The List attribute.

##### *itemType* (Optional)
Type: [System.String][3]  
Type of the new item (ignored for a list attribute containing items)

##### *itemName* (Optional)
Type: [System.String][3]  
Name of the item (ignored for an ordered list attribute).

#### Return Value
Type: [AttributeType][2]  
the added list item Attribute.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [AttributeType][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][4] or [Extension Methods (C# Programming Guide)][5].

See Also
--------

#### Reference
[ListAttribute Class][6]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/AttributeType/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[5]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png