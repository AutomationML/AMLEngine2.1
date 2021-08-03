# AMLFile.GetMetaInformation Method 
AutomationML 2.1 API 

This methods returns an Enumeration of all "WriterHeader" meta information out of an existing AutomationML file.

**Namespace:**&nbsp;<a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<MetaInformation> GetMetaInformation()
```

**VB**<br />
``` VB
Public Function GetMetaInformation As IEnumerable(Of MetaInformation)
```

**C++**<br />
``` C++
public:
IEnumerable<MetaInformation^>^ GetMetaInformation()
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_AmlObjects_MetaInformation">MetaInformation</a>)<br />Enumerable with element containing all meta information, or null if no meta information is existing

## Exceptions
&nbsp;<table><tr><th>Exception</th><th>Condition</th></tr><tr><td><a href="https://docs.microsoft.com/dotnet/api/system.argumentoutofrangeexception" target="_parent" rel="noopener noreferrer">ArgumentOutOfRangeException</a></td><td /></tr></table>

## Remarks
Extension Method originally designed for AutomationML Versions based on CAEX 2.15.

## See Also


#### Reference
<a href="T_Aml_Engine_AmlObjects_AMLFile">AMLFile Class</a><br /><a href="Overload_Aml_Engine_AmlObjects_AMLFile_GetMetaInformation">GetMetaInformation Overload</a><br /><a href="N_Aml_Engine_AmlObjects">Aml.Engine.AmlObjects Namespace</a><br />