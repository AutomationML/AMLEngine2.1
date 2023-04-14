There are two different methods of embedding [DocumentVersionInformation elements](https://github.com/AutomationML/AMLEngine2.1/blob/master/Documentation/Aml.Engine.AmlObjects/DocumentVersionInformation/README.md) into a CAEXFile object in the engine.

1. [DocumentVersions.AppendDocumentVersionInformation](https://github.com/AutomationML/AMLEngine2.1/blob/master/Documentation/Aml.Engine.AmlObjects/DocumentVersions/AppendDocumentVersionInformation_1.md)
2. [AMLFile.DocumentVersion](https://github.com/AutomationML/AMLEngine2.1/blob/master/Documentation/Aml.Engine.AmlObjects/AMLFile/DocumentVersion.md)

The result of the first method is:

```XML
<AdditionalInformation DocumentVersions="Recommendations">
    <Document xmlns="" DocumentIdentifier="VDI/VDE/NAMUR 2658-1:Manifest" Version="1.1.0" />
    <Document xmlns="" DocumentIdentifier="VDI/VDE/NAMUR 2658-4:ServiceSet" Version="1.0.0" />
    <Document xmlns="" DocumentIdentifier="VDI/VDE/NAMUR 2658-2:HmiSet" Version="1.0.0" />
 </AdditionalInformation>
```

Adding elements to the sequence provided with option two, results in:

```XML
<AdditionalInformation DocumentVersions="Recommendations">
    <Document DocumentIdentifier="VDI/VDE/NAMUR 2658-1:Manifest" Version="1.1.0" />
</AdditionalInformation>
<AdditionalInformation DocumentVersions="Recommendations">
    <Document DocumentIdentifier="VDI/VDE/NAMUR 2658-4:ServiceSet" Version="1.0.0" />
</AdditionalInformation>
<AdditionalInformation DocumentVersions="Recommendations">
    <Document DocumentIdentifier="VDI/VDE/NAMUR 2658-2:HmiSet" Version="1.0.0" />
</AdditionalInformation>
```

Unfortunately, both methods are incompatible. If the document versions were realized with method 1, they will not be listed in method 2 and vice versa. With version 3.1 of the Aml.Engine, this has been corrected. The engine will only create the structure, defined by the first method, but both methods will recognize each version. 
If the DocumentVersionInformation in the CAEXFile was edited with the AutomaitionML Editor, you should use the second method to retrieve the information. With Editor version 6.2, the editor will also create a structure as defined by the first method.
