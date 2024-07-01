using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using Aml.Engine.Resources.Files;
using Aml.Engine.Services.LibraryService;
using Aml.Engine.Services.Model;

namespace Aml.Engine.Tutorial.LibraryServiceTutorial
{
    /// <summary>
    /// Tutorial to access hosted data from the AutomationML library server using
    /// the AMLFileService. 
    /// In this tutorial it is explained, how the AMLFileService 
    /// can be used to get access to AutomationML 
    /// files located on a remote storage location hosted by AutomationML. The AMLFileService
    /// uses built in AML Server profiles.
    /// </summary>
    internal static class AMLFileServiceTutorial
    {
        static AMLFileService _amlFileService;

        public static bool Initialize()
        {
            _amlFileService = new AMLFileService();

            if (_amlFileService.AMLReadProfile == null)
            {
                Console.WriteLine("No read profile loaded for the AutomationML file service");
            }

            if (_amlFileService.AMLWriteProfile == null)
            {
                Console.WriteLine("No write profile loaded for the AutomationML file service");
            }

            return _amlFileService.AMLReadProfile != null && _amlFileService.AMLWriteProfile != null;
        }


        /// <summary>
        /// Lists the hosted data on the AutomationML file server asynchronous.
        /// </summary>
        /// <returns></returns>
        internal static async Task<bool> ListHostedDataAsync()
        {
            if (_amlFileService.AMLReadProfile == null)
            {
                return false;
            }

            int j = 0;
            // a profile can define multiple library data folder profiles (i.e. one folder for each domain or edition)

            var amlLibraryDocumentsList = await _amlFileService.GetAMLLibraryDocumentsAsync();
            if (amlLibraryDocumentsList.Count == 0)
            {
                Console.WriteLine($"No documemts hosted on AutomationML Library Server");
            }

            // Note, that the metadata is analyzed by parsing the filename. If the filename does not meet the
            // naming conventions, these data may not correctly specify the files content.
            foreach (var hostedFile in amlLibraryDocumentsList)
            {
                j++;
                // It is checked, if the meta data can provide all required informaton for 
                // AutomationML document files.
                if (!hostedFile.IsConsistent)
                {
                    Console.WriteLine($"{j}: {hostedFile.Name} does not meet the naming conventions.");
                    continue;
                }

                Console.WriteLine($"{j}: {hostedFile.Name}");
                Console.WriteLine($"\tURL: {hostedFile.URL}");
                Console.WriteLine($"\tProducer: {hostedFile.Producer}; Type: {hostedFile.ContentType}; Domain: {hostedFile.Domain}; Edition: {hostedFile.Edition}");
            }
            return true;
        }


        /// <summary>
        /// Create a new document referencing all base libraries, provided by the server asynchronous.
        /// </summary>
        internal static async Task<CAEXDocument> UseHostedBaseLibrariesAsync()
        {
            var caexDocument = CAEXDocument.New_CAEXDocument();
            if (_amlFileService.AMLReadProfile == null)
            {
                return caexDocument;
            }

            var baseDocuments = await _amlFileService.GetDomainDocumentsAsync(AMLFileMetaModel.BASE_DOMAIN, CAEXDocument.CAEXSchema.CAEX3_0, AMLEditionEnum.Edition2);
            if (baseDocuments.Count == 0)
            {
                Console.WriteLine("No hosted Base libraries found.");
            }

            // reference the base documents which are found using external references, added to the new document
            foreach (var baseDocument in baseDocuments)
            {
                // The url is defined in the returned meta data.
                // An alias name is proposed but can be changed.
                Console.WriteLine($"{baseDocument.URL} referenced.");

                caexDocument.CAEXFile.New_ExternalReference(baseDocument.URL, baseDocument.AliasNameFromParts);
            }
            return caexDocument;
        }
    }
}
