ListAttribute.CreateListAttribute Method
========================================
Creates a new list attribute for an element which can have attributes.

  **Namespace:**  [Aml.Engine.AmlObjects][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static AttributeType CreateListAttribute(
	this IObjectWithAttributes element,
	string attributeName,
	int itemsCount,
	string itemType,
	string itemName = "item",
	bool isOrderedList = false
)
```

#### Parameters

##### *element*
Type: [Aml.Engine.CAEX.IObjectWithAttributes][2]  
The element.

##### *attributeName*
Type: [System.String][3]  
Name of the new list attribute.

##### *itemsCount*
Type: [System.Int32][4]  
The items count for initialization of the containing attribute items.

##### *itemType*
Type: [System.String][3]  
Type of the item (unique for all items).

##### *itemName* (Optional)
Type: [System.String][3]  
 Name of the item (ignored if an ordered list is created). When an item attribute is created, the item Name gets the item index added to this name.

##### *isOrderedList* (Optional)
Type: [System.Boolean][5]  
if set to `true` the list is an ordered list.

#### Return Value
Type: [AttributeType][6]  
The list AttributeType.
#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [IObjectWithAttributes][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][7] or [Extension Methods (C# Programming Guide)][8].

See Also
--------

#### Reference
[ListAttribute Class][9]  
[Aml.Engine.AmlObjects Namespace][1]  

[1]: ../README.md
[2]: ../../Aml.Engine.CAEX/IObjectWithAttributes/README.md
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.int32
[5]: https://docs.microsoft.com/dotnet/api/system.boolean
[6]: ../../Aml.Engine.CAEX/AttributeType/README.md
[7]: https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods
[8]: https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[9]: README.md
[10]: https://www.automationml.org
[11]: ../../icons/logoShade.png