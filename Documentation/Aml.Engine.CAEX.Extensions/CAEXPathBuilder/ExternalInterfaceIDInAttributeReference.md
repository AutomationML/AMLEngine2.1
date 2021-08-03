CAEXPathBuilder.ExternalInterfaceIDInAttributeReference Method
==============================================================
AutomationML 2.1 APICheck, if the provided reference is a reference to an attribute of an ExternalInterface, using the ID of an ExternalInterface.

  **Namespace:**  [Aml.Engine.CAEX.Extensions][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static string ExternalInterfaceIDInAttributeReference(
	string reference,
	CAEXDocument cAEXDocument,
	out bool isIdReference
)
```

#### Parameters

##### *reference*
Type: [System.String][2]  
The reference.

##### *cAEXDocument*
Type: [Aml.Engine.CAEX.CAEXDocument][3]  
The CAEX document.

##### *isIdReference*
Type: [System.Boolean][4]  
if set to `true` a valid ID is used to reference an ExternalInterface.

#### Return Value
Type: [String][2]  
the normalized ID if the reference contains an ID

Remarks
-------
This method only recognizes GUIDs in a reference.

See Also
--------

#### Reference
[CAEXPathBuilder Class][5]  
[Aml.Engine.CAEX.Extensions Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: ../../Aml.Engine.CAEX/CAEXDocument/README.md
[4]: https://docs.microsoft.com/dotnet/api/system.boolean
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png