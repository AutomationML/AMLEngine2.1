# ListAttribute Methods
AutomationML 2.1 API 

The <a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute</a> type exposes the following members.


## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_AddListItem">AddListItem</a></td><td>
Adds an additional list item attribute to the list attribute. If the List attribute already contains some items, the new item will have the same item type as the already existing items. If this is the first item, the specified itemType is used as the attribute data type. If no itemType is defined, the default data type for the list item is "xs:string". The Item name is automatically set to the Index if the List attribute is an ordered list, otherwise the defined itemName is used.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_ConvertToListAttribute">ConvertToListAttribute</a></td><td>
Changes the semantic of the specified attribute and converts to a list attribute. A first item is added to the List attribute which is initialized with valued from the converted attribute. If the Attribute is already a list attribute or the attribute contains child attributes it will not be converted.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_CreateListAttribute">CreateListAttribute</a></td><td>
Creates a new list attribute for an element which can have attributes.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_IsListAttribute">IsListAttribute</a></td><td>
Determines whether the specified attribute is a list attribute. This can be ordered or unordered.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_IsOrderedListAttribute">IsOrderedListAttribute</a></td><td>
Determines whether the specified attribute is an ordered list attribute.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_IsUnOrderedListAttribute">IsUnOrderedListAttribute</a></td><td>
Determines whether the specified attribute is an unordered list attribute.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_ListItems">ListItems</a></td><td>
Gets the values of all items in the list attribute</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_ListItemValues">ListItemValues</a></td><td>
Gets the values of all items in the list attribute</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")![Static member](media/static.gif "Static member")</td><td><a href="M_Aml_Engine_AmlObjects_ListAttribute_MakeListAttribute">MakeListAttribute</a></td><td>
Changes the semantic of the specified attribute and converts it to a list attribute. If the Attribute is already a list attribute or the attribute contains child attributes it will not be converted.</td></tr></table>&nbsp;
<a href="#listattribute-methods">Back to Top</a>

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_ListAttribute">ListAttribute Class</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />