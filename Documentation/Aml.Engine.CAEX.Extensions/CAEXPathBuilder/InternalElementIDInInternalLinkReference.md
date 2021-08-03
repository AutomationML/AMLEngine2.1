CAEXPathBuilder.InternalElementIDInInternalLinkReference Method
===============================================================
AutomationML 2.1 APIGets the InternalElement ID from a reference defined in an InternalLink object.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string InternalElementIDInInternalLinkReference(
	string reference,
	out bool isInterfaceReference
)
```

#### Parameters

##### *reference*
Type: [System.String][2]  
The reference from the InternalLink object.

##### *isInterfaceReference*
Type: [System.Boolean][3]  
if set to `true` [is interface reference].

#### Return Value
Type: [String][2]  
 The InternalElement ID 

Remarks
-------
 Only valid for CAEX Version 2.15 

See Also
--------

#### Reference
[CAEXPathBuilder Class][4]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.boolean
[4]: README.md
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png