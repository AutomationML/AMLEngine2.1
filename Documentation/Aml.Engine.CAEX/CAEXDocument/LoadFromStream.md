CAEXDocument.LoadFromStream Method
==================================
Create a CAEX document with content, loaded from a stream. The schema version of the CAEX document is set accordingly to the SchemaVersion-Attribute of the CAEXFile object.

  **Namespace:**  [Aml.Engine.CAEX][1]  
  **Assembly:**  AML.Engine (in AML.Engine.dll)

Syntax
------

```csharp
public static CAEXDocument LoadFromStream(
	Stream inStream
)
```

#### Parameters

##### *inStream*
Type: [System.IO.Stream][2]  
The content stream.

#### Return Value
Type: [CAEXDocument][3]  
 The CAEX document. 

Exceptions
----------

Exception                  | Condition 
-------------------------- | --------- 
[ArgumentNullException][4] | inStream  


See Also
--------

#### Reference
[CAEXDocument Class][3]  
[Aml.Engine.CAEX Namespace][1]  

[1]: ../README.md
[2]: https://docs.microsoft.com/dotnet/api/system.io.stream
[3]: README.md
[4]: https://docs.microsoft.com/dotnet/api/system.argumentnullexception
[5]: https://www.automationml.org
[6]: ../../icons/logoShade.png