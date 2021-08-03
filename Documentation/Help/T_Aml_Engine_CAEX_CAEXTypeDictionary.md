# CAEXTypeDictionary Class
AutomationML 2.1 API 

Class CAEXTypeDictionary is a Dictionary of all CAEX - WrapperClass Types, defined in Aml.Engine.CAEX. The TypeName is used as a key. This class is a singleton.


## Inheritance Hierarchy
<a href="https://docs.microsoft.com/dotnet/api/system.object" target="_parent" rel="noopener noreferrer">System.Object</a><br />&nbsp;&nbsp;<a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.dictionary-2" target="_parent" rel="noopener noreferrer">System.Collections.Generic.Dictionary</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>, <a href="https://docs.microsoft.com/dotnet/api/system.type" target="_parent" rel="noopener noreferrer">Type</a>)<br />&nbsp;&nbsp;&nbsp;&nbsp;Aml.Engine.CAEX.CAEXTypeDictionary<br />
**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public class CAEXTypeDictionary : Dictionary<string, Type>
```

**VB**<br />
``` VB
Public Class CAEXTypeDictionary
	Inherits Dictionary(Of String, Type)
```

**C++**<br />
``` C++
public ref class CAEXTypeDictionary : public Dictionary<String^, Type^>
```

The CAEXTypeDictionary type exposes the following members.


## Properties
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public property](media/pubproperty.gif "Public property")</td><td><a href="P_Aml_Engine_CAEX_CAEXTypeDictionary_Item">Item</a></td><td>
Gets or sets the data type associated with the specified key.</td></tr></table>&nbsp;
<a href="#caextypedictionary-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXTypeDictionary_ContainsKey">ContainsKey</a></td><td>
Determines whether this dictionary's key collection contains the specified CAEX Tag name as a key.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXTypeDictionary_TryGetCreator">TryGetCreator</a></td><td>
Tries to get the constructor function which can be used to create a CAEX wrapper for an CAEX element with the provided element name.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Aml_Engine_CAEX_CAEXTypeDictionary_TryGetValue">TryGetValue</a></td><td>
Tries to get the value.</td></tr></table>&nbsp;
<a href="#caextypedictionary-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")![Static member](media/static.gif "Static member")</td><td><a href="F_Aml_Engine_CAEX_CAEXTypeDictionary_Instance">Instance</a></td><td>
The singleton instance of the CAEXType Dictionary</td></tr></table>&nbsp;
<a href="#caextypedictionary-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br /><a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.dictionary-2" target="_parent" rel="noopener noreferrer">System.Collections.Generic.Dictionary(TKey, TValue)</a><br />