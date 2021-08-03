# CAEXObject.CAEXPath Method 
AutomationML 2.1 API 

Gets the CAEX path for this object. A path can be used to uniquely reference an object, for example in inheritances and instances. The path syntax for an object is defined differently in CAEX 2.15 and CAEX 3.0. The engine uses the <a href="T_Aml_Engine_CAEX_Extensions_CAEXPathBuilder">CAEXPathBuilder</a> to generate the CAEX path of an object according to the documents CAEX version.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public string CAEXPath()
```

**VB**<br />
``` VB
Public Function CAEXPath As String
```

**C++**<br />
``` C++
public:
virtual String^ CAEXPath() sealed
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a><br />The CAEX path.

#### Implements
<a href="M_Aml_Engine_CAEX_ICAEXObject_CAEXPath">ICAEXObject.CAEXPath()</a><br />

## Remarks
Paths require the definition of separators between different path elements. CAEX 2.15 distinguishes between 4 separator types: Alias separator, object separator, interface separator and attribute separator. In CAEX 3.0 only the separator types Alias separator and object separator are used. 
Please note that this method returns a different result than the <a href="M_Aml_Engine_CAEX_Extensions_CAEXObjectExtensions_GetFullNodePath">GetFullNodePath(ICAEXObject)</a> method, which always returns the path including the object names of all ancestor hierarchy levels.


## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_CAEXObject">CAEXObject Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />