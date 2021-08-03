# QueryResult.CaexObjectsOfType(*T*) Method 
AutomationML 2.1 API 

Gets the CAEX objects of the specified type from the query result.

**Namespace:**&nbsp;<a href="N_Aml_Engine_Services">Aml.Engine.Services</a><br />**Assembly:**&nbsp;AML.Engine (in AML.Engine.dll) Version: 1.6

## Syntax

**C#**<br />
``` C#
public static IEnumerable<T> CaexObjectsOfType<T>(
	this ILookup<string, ICAEXReference> queryResult
)
where T : CAEXBasicObject

```

**VB**<br />
``` VB
<ExtensionAttribute>
Public Shared Function CaexObjectsOfType(Of T As CAEXBasicObject) ( 
	queryResult As ILookup(Of String, ICAEXReference)
) As IEnumerable(Of T)
```

**C++**<br />
``` C++
public:
[ExtensionAttribute]
generic<typename T>
where T : CAEXBasicObject
static IEnumerable<T>^ CaexObjectsOfType(
	ILookup<String^, ICAEXReference^>^ queryResult
)
```


#### Parameters
&nbsp;<dl><dt>queryResult</dt><dd>Type: <a href="https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2" target="_parent" rel="noopener noreferrer">System.Linq.ILookup</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>, <a href="T_Aml_Engine_Services_Interfaces_ICAEXReference">ICAEXReference</a>)<br />The queryResult.</dd></dl>

#### Type Parameters
&nbsp;<dl><dt>T</dt><dd>Type of the required CAEX object.</dd></dl>

#### Return Value
Type: <a href="https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1" target="_parent" rel="noopener noreferrer">IEnumerable</a>(*T*)<br />An enumeration of all CAEX objects of the specified type in the query result.

#### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type <a href="https://docs.microsoft.com/dotnet/api/system.linq.ilookup-2" target="_parent" rel="noopener noreferrer">ILookup</a>(<a href="https://docs.microsoft.com/dotnet/api/system.string" target="_parent" rel="noopener noreferrer">String</a>, <a href="T_Aml_Engine_Services_Interfaces_ICAEXReference">ICAEXReference</a>). When you use instance method syntax to call this method, omit the first parameter. For more information, see <a href="https://docs.microsoft.com/dotnet/visual-basic/programming-guide/language-features/procedures/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (Visual Basic)</a> or <a href="https://docs.microsoft.com/dotnet/csharp/programming-guide/classes-and-structs/extension-methods" target="_blank" rel="noopener noreferrer">Extension Methods (C# Programming Guide)</a>.

## See Also


#### Reference
<a href="T_Aml_Engine_Services_QueryResult">QueryResult Class</a><br /><a href="N_Aml_Engine_Services">Aml.Engine.Services Namespace</a><br />