# ValueSequence(*TDataType*).GetEnumerator Method 
AutomationML 2.1 API 

Gets the enumerator for this sequence which enumerates the <a href="P_Aml_Engine_CAEX_ValueSequence_1_Values">Values</a>.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public override IEnumerator<TDataType> GetEnumerator()
```

**VB**<br />
``` VB
Public Overrides Function GetEnumerator As IEnumerator(Of TDataType)
```

**C++**<br />
``` C++
public:
virtual IEnumerator<TDataType>^ GetEnumerator() override
```


#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerator-1" target="_parent" rel="noopener noreferrer">IEnumerator</a>(<a href="T_Aml_Engine_CAEX_ValueSequence_1">*TDataType*</a>)<br />An enumerator that can be used to iterate through the collection.

#### Implements
<a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1.getenumerator#System_Collections_Generic_IEnumerable_1_GetEnumerator" target="_parent" rel="noopener noreferrer">IEnumerable(T).GetEnumerator()</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_ValueSequence_1">ValueSequence(TDataType) Class</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />