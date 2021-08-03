# InterfaceFamilyType.GetReferenceHierarchy(*T*) Method 
AutomationML 2.1 API 

**Note: This API is now obsolete.**

Gets the reference (Inheritance) hierarchy including this instance in an ordered sequence of ancestors.

**Namespace:**&nbsp;<a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
[ObsoleteAttribute("Use the more specific method")]
public Queue<T> GetReferenceHierarchy<T>()
where T : IClassWithBaseClassReference

```

**VB**<br />
``` VB
<ObsoleteAttribute("Use the more specific method")>
Public Function GetReferenceHierarchy(Of T As IClassWithBaseClassReference) As Queue(Of T)
```

**C++**<br />
``` C++
public:
[ObsoleteAttribute(L"Use the more specific method")]
generic<typename T>
where T : IClassWithBaseClassReference
virtual Queue<T>^ GetReferenceHierarchy() sealed
```


#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>Type of the CAEX class in the hierarchy.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.queue-1" target="_parent" rel="noopener noreferrer">Queue</a>(*T*)<br />a queue of ancestors. this instance is first in the queue

#### Implements
<a href="M_Aml_Engine_CAEX_IClassWithBaseClassReference_GetReferenceHierarchy__1">IClassWithBaseClassReference.GetReferenceHierarchy(T)()</a><br />

## See Also


#### Reference
<a href="T_Aml_Engine_CAEX_InterfaceFamilyType">InterfaceFamilyType Class</a><br /><a href="Overload_Aml_Engine_CAEX_InterfaceFamilyType_GetReferenceHierarchy">GetReferenceHierarchy Overload</a><br /><a href="N_Aml_Engine_CAEX">Aml.Engine.CAEX Namespace</a><br />