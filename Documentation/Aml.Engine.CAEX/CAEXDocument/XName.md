CAEXDocument.XName Method
=========================
Gets the correct XName for the provided CAEX element name (Tag name).The XName contains a namespace, if the assigned schema requires a namespace. If no namespace is defined for the assigned schema (as in CAEX 2.15), no namespace is added to the XName. The XName has to be used for all Xml.Linq queries, used to access objects with the CAEX element name.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public override XName XName(
	string tagname
)
```

#### Parameters

##### *tagname*
Type: [System.String][2]  
A CAEX Tag name which should be transformed to a XName.

#### Return Value
Type: [XName][3]  
The generated XName.

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][4] | tag name  


See Also
--------

#### Reference
[CAEXDocument Class][5]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.string
[3]: https://docs.microsoft.com/dotnet/api/system.xml.linq.xname
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: README.md
[6]: https://www.automationml.org
[7]: ../../icons/logoShade.png