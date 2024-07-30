using Aml.Engine.AmlObjects.Extensions;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using Aml.Engine.Resources.Files;
using Aml.Engine.Services.LibraryService;
using Aml.Engine.Services.Model;

namespace Aml.Engine.Tutorial.LibraryServiceTutorial
{
    /// <summary>
    /// Tutorial to access hosted data from an AutomationML library server. 
    /// In this tutorial it is explained, how an AMLLibraryServerProfile 
    /// can be used together with a library service to get access to AutomationML 
    /// files located on a remote storage location.
    /// </summary>
    internal static class LibraryServiceProfileTutorial
    {
        /// <summary>
        /// The aml library service used to get the documents from the AML plattform
        /// </summary>
        static WebDAVHttpsClient? LibraryService;

        /// <summary>
        /// Initializes the server connection.
        /// </summary>
        /// <returns></returns>
        internal static async Task<bool> InitializeAsnyc()
        {
            // Load the configured server profile using the profile defining file.
            // The server profile for released AutomationML documents is used here.
            var serverProfile = AMLLibraryServerProfile.LoadFromFile("Release.profile.json");

            // create a webdavhttps client using this profile (webdav https is defined
            // as the network protocol in the defined profile)            
            LibraryService = new WebDAVHttpsClient();

            if (!await LibraryService.RegisterServerProfileAsync(serverProfile))
            {
                Console.WriteLine($"No connection to {serverProfile.ServerName}");
                return false;
            }
            Console.WriteLine($"Connection to {serverProfile.ServerName} successful.");
            return true;
        }

        /// <summary>
        /// Lists the hosted data on the server asynchronous.
        /// </summary>
        internal static async Task<bool> ListHostedDataAsync()
        {
            if (LibraryService == null)
            {
                return false;
            }

            // The LibraryData Folder profile is used to get access to the hosted Library documents
            if (LibraryService.ServerProfile?.LibraryData != null)
            {
                int j = 0;
                // a profile can define multiple library data folder profiles (i.e. one folder for each domain or edition)
                foreach (var libraryData in LibraryService.ServerProfile.LibraryData)
                {
                    // get the hosted data (this gets the document metadata, not the documents content)
                    var amlLibraryDocumentsList = await LibraryService.GetDocumentsAsync(libraryData);
                    if (amlLibraryDocumentsList.Count == 0)
                    {
                        Console.WriteLine($"No documemts hosted on {LibraryService.ServerProfile.GetUri(libraryData)}");
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
                            Console.WriteLine($"{j}: {hostedFile.FileName} does not meet the naming conventions.");
                            continue;
                        }

                        Console.WriteLine($"{j}: {hostedFile.FileName}");
                        Console.WriteLine($"\tURL: {hostedFile.URL}");
                        Console.WriteLine($"\tProducer: {hostedFile.Producer}; Type: {hostedFile.ContentType}; Domain: {hostedFile.Domain}; Edition: {hostedFile.Edition}");
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Create a new document referencing all base libraries, provided by the server asynchronous.
        /// </summary>
        internal static async Task<CAEXDocument> UseHostedBaseLibrariesAsync()
        {
            var caexDocument = CAEXDocument.New_CAEXDocument();
            if (LibraryService == null)
            {
                // returns the empty document
                return caexDocument;
            }
          

            // The LibraryData Folder profile is used to get access to the hosted Library documents
            if (LibraryService.ServerProfile?.LibraryData != null)
            {
                // a profile can define multiple library data folder profiles (i.e. one folder for each domain or edition)
                // Preselect only those profiles, which are defined for the document edition.
                // Be aware, that a profile can still be configured to host various editions.
                var dataProfilesForDocumentEdition = LibraryService.ServerProfile.LibraryData.Where(d => d.AutomationMLEdition.IsDocumentEdition(caexDocument));
                List<AMLFileMetaModel> hostedDocuments = [];

                foreach (var libraryData in dataProfilesForDocumentEdition)
                {
                    // get the hosted data (this gets the document metadata, not the documents content)
                    hostedDocuments.AddRange(await LibraryService.GetDocumentsAsync(libraryData));
                }

                // Filter the list for documents, which are defined by AutomationML for the Base domain and 
                // are equivalent to the document edition.
                // 'Base' is a standard domain and 'AutomationML' is a standard producer.
                var baseDocuments = hostedDocuments.Where(d => d.Domain == AMLFileMetaModel.BASE_DOMAIN &&
                d.Producer == AMLFileMetaModel.AML_PRODUCER && d.IsDocumentEdition(caexDocument.AutomationMLVersion()));

                // Please note, that you will get all versions of base documents here.
                // To be sure to get a specific version or always the latest version,
                // additional filtering steps are needed.

                // Versions can be identified using different methods
                // - Analyzing the Metadata only as shown here 
                // - Loading the documents and analyzing the included version references
                // - Using the registration data for libraries from the Library Catalogue

                // Get only the latest versions from this list using the version information, defined in the meta data
                baseDocuments = AMLFileMetaModel.GetLatestVersions(baseDocuments);

                if (!baseDocuments.Any())
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
            }

            return caexDocument;
        }

        /// <summary>
        /// Load the library catalog and hosted on the server and perform some tests.
        /// </summary>
        internal static async Task UseHostedLibraryCatalogAsync()
        {
            if (LibraryService?.ServerProfile == null)
            {
                return;
            }

            // The LibraryCatalogData Folder profile is used to get access to the hosted Library catalogue
            if (LibraryService.ServerProfile?.LibraryCatalogData != null)
            {
                var libraryCatalog = await LibraryService.LoadLibraryCatalogAsync(LibraryService.ServerProfile.LibraryCatalogData);
                if (libraryCatalog == null)
                {
                    Console.WriteLine($"No Library Catalog defined on {LibraryService.ServerProfile.GetUri(LibraryService.ServerProfile.LibraryCatalogData)}");
                    return;
                }

                // Print all RoleClassLibraries
                foreach (var roleClassLibraryData in libraryCatalog.Libraries(CAEX_CLASSModel_TagNames.ROLECLASSLIB_STRING))
                {
                    Console.WriteLine($"RoleClassLibrary: {roleClassLibraryData.Name}");
                    foreach (var version in roleClassLibraryData.Versions)
                    {
                        Console.WriteLine($"\tLib Version: {version.Version}; Edit.: {version.AMLEdition}");
                    }
                }

                // load a document, containing the latest version of the AutomationML Base RoleClassLib using the download link
                var amlBaseRoleClassLibData = libraryCatalog[CAEX_CLASSModel_TagNames.ROLECLASSLIB_STRING, AmlObjects.AutomationMLBaseRoleClassLib.AutomationMLBaseRoleClassLibName];
                Console.WriteLine($"\nLoading {AmlObjects.AutomationMLBaseRoleClassLib.AutomationMLBaseRoleClassLibName}");
                Console.WriteLine($"\t{amlBaseRoleClassLibData.Versions.Count} listed versions of {amlBaseRoleClassLibData.Name}");
                
                var recentVersion = amlBaseRoleClassLibData.HighestVersion(CAEXDocument.SchemaToString(CAEXDocument.CAEXSchema.CAEX3_0));
                
                Console.WriteLine($"\t{recentVersion.Version} found as the most recent version");

                // a version may define multiple download links, here we use the link which provides
                // the raw aml file. There can be links, providing zip containers
                var (LinkAddress, Revision) = recentVersion.AllDownloadLinks.FirstOrDefault(l => l.LinkAddress.EndsWith(".aml"));
                if (string.IsNullOrEmpty(LinkAddress))
                {
                    Console.WriteLine("\tNo valid download link found for an AML file");
                    return;
                }
                Console.WriteLine($"\t{LinkAddress} found as the download link");

                // for aml files, the external reference resolver service can be used to load the document
                var service = Services.ExternalReferenceResolver.Register();
                var (Document, Message) = service.ResolveExternalDocument(LinkAddress);

                if (Document == null)
                {
                    Console.WriteLine($"\t{Message}");
                    return;
                }

                // now we can check, if the baseRoleClassLib is the signed an verified version using
                // the signature which is listed in the data repository
                if (string.IsNullOrEmpty(Revision.Signature))
                {
                    Console.WriteLine($"\tNo signature found in the library repository");
                    return;
                }

                var roleClassLib = Document.CAEXFile.RoleClassLib[AmlObjects.AutomationMLBaseRoleClassLib.AutomationMLBaseRoleClassLibName];
                if (roleClassLib == null)
                {
                    Console.WriteLine($"\tNo AutomationML Base roleClass library found in the loaded document.");
                    return;
                }

                // AutomationML uses the ECDSASigningService 
                var signService = Services.Signing.ECDSASigningService.Register();

                // Verification needs the public key, which is provided in the library catalog
                var isVerified = signService.VerifySignature(roleClassLib, Revision.Signature, libraryCatalog.PublicKey);
                Console.WriteLine($"\tVerification result: {isVerified}");
            }
        }
    }
}
