# InternalElementSequence.InternalElementDescendantsAndSelf Method 
AutomationML 2.1 API 

Gets all InternalElements and the InternalElement descendants (the InternalElement tree)

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public IEnumerable<InternalElementType> InternalElementDescendantsAndSelf()
```

**VB**<br />
``` VB
Public Function InternalElementDescendantsAndSelf As IEnumerable(Of InternalElementType)
```

**C++**<br />
``` C++
public:
IEnumerable<InternalElementType^>^ InternalElementDescendantsAndSelf()
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(<a href="T_Aml_Engine_CAEX_InternalElementType">InternalElementType</a>)<br />a collection of all InternalElement objects of this instance and their nested InternalElement objects.

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InternalElementSequence">InternalElementSequence Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />