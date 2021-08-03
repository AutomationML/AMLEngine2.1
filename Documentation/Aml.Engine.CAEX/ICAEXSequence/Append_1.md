ICAEXSequence.Append Method (ValueTuple&lt;String, Object>[])
=============================================================
Creates a new CAEX object and appends it to already existing elements. The content of the new element can be optionally defined using an array of tuples defining attribute names and their values.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
ICAEXWrapper Append(
	params (string , Object )[] attributeValueTuples
)
```

#### Parameters

##### *attributeValueTuples*
Type: [System.ValueTuple][2]&lt;[String][3], [Object][4]>[]  
The attribute value tuples.

#### Return Value
Type: [ICAEXWrapper][5]  
 the created CAEX object. 

Examples
--------
 This sample shows how to apply this method: 
```csharp
var doc = CAEXDocument.New();
var at =  doc.CAEXFile.AttributeTypeLib.Append (new Tuple <string,object>[] { Tuple.Create<string,object>("Name", "ALIB") });
```


See Also
--------

#### Reference
[ICAEXSequence Interface][6]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.valuetuple-2
[3]: https://docs.microsoft.com/dotnet/api/system.string
[4]: https://docs.microsoft.com/dotnet/api/system.object
[5]: ../ICAEXWrapper/README.md
[6]: README.md
[7]: https://www.automationml.org
[8]: ../../icons/logoShade.png