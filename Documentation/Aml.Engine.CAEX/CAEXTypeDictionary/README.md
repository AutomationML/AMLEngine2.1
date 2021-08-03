CAEXTypeDictionary Class
========================
AutomationML 2.1 APIClass CAEXTypeDictionary is a Dictionary of all CAEX - WrapperClass Types, defined in Aml.Engine.CAEX. The TypeName is used as a key. This class is a singleton.


Inheritance Hierarchy
---------------------
[System.Object][1]  
  [System.Collections.Generic.Dictionary][2]&lt;[String][3], [Type][4]>  
    **Aml.Engine.CAEX.CAEXTypeDictionary**  

  **Namespace:**  [Aml.Engine.CAEX][5]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public class CAEXTypeDictionary : Dictionary<string, Type>
```

The **CAEXTypeDictionary** type exposes the following members.


Properties
----------

                   | Name      | Description                                                   
------------------ | --------- | ------------------------------------------------------------- 
![Public property] | [Item][6] | Gets or sets the data type associated with the specified key. 


Methods
-------

                 | Name               | Description                                                                                                                          
---------------- | ------------------ | ------------------------------------------------------------------------------------------------------------------------------------ 
![Public method] | [ContainsKey][7]   | Determines whether this dictionary's key collection contains the specified CAEX Tag name as a key.                                   
![Public method] | [TryGetCreator][8] | Tries to get the constructor function which can be used to create a CAEX wrapper for an CAEX element with the provided element name. 
![Public method] | [TryGetValue][9]   | Tries to get the value.                                                                                                              


Fields
------

                                | Name           | Description                                       
------------------------------- | -------------- | ------------------------------------------------- 
![Public field]![Static member] | [Instance][10] | The singleton instance of the CAEXType Dictionary 


See Also
--------

#### Reference
[Aml.Engine.CAEX Namespace][5]  
[System.Collections.Generic.Dictionary&lt;TKey, TValue>][2]  

[1]: https://docs.microsoft.com/dotnet/api/system.object
[2]: https://docs.microsoft.com/dotnet/api/system.collections.generic.dictionary-2
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.type
[5]: ../README.md
[6]: Item.md
[7]: ContainsKey.md
[8]: TryGetCreator.md
[9]: TryGetValue.md
[10]: Instance.md
[11]: https://www.automationml.org
[12]: ../../icons/logoShade.png
[Public property]: ../../icons/pubproperty.gif "Public property"
[Public method]: ../../icons/pubmethod.gif "Public method"
[Public field]: ../../icons/pubfield.gif "Public field"
[Static member]: ../../icons/static.gif "Static member"