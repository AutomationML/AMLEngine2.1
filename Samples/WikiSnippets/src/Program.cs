// Copyright (c) 2021 Josef Prinz. All rights reserved.
// Licensed under the MIT License, see License.txt in the project root for license information.

using Aml.Engine.CAEX;
using Aml.Editor.IPC;
using System;
using System.Diagnostics;

namespace Aml.Engine.Wiki.Snippets
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Code Snippets published in the Aml.Engine Wiki");
            CAEXDocument document;

            Basic.CopyElements(document=CAEXDocument.New_CAEXDocument());
            ShowResult(document, "Basic.CopyElements");
            Basic.InsertElements(document = CAEXDocument.New_CAEXDocument());
            ShowResult(document, "Basic.InsertElements");
            Basic.RemoveElements(document = CAEXDocument.New_CAEXDocument());
            ShowResult(document, "Basic.RemoveElements");

            Inheritance.CreateSystemUnitClassInheritance(document = CAEXDocument.New_CAEXDocument());
            ShowResult(document, "Inheritance.CreateSystemUnitClassInheritance");
            Inheritance.CreateOverridenAttributes(document = CAEXDocument.New_CAEXDocument());
            ShowResult(document, "Inheritance.CreateOverridenAttributes");
            Inheritance.CheckRoleReference(document = CAEXDocument.New_CAEXDocument());
            ShowResult(document, "Inheritance.CheckRoleReference");

            Mirrors.UsingAttributeMirrors(document = CAEXDocument.New_CAEXDocument());
            ShowResult(document, "Mirrors.UsingAttributeMirrors");

            Attributes.AttributeValuesAndDataTypes(document = CAEXDocument.New_CAEXDocument());
            ShowResult(document, "Attributes.AttributeValuesAndDataTypes");

            Relations.RoleInstantiation(document = CAEXDocument.New_CAEXDocument());
            ShowResult(document, "Relations.RoleInstantiation");
            Relations.CreateSystemUnitClassInstance(document = CAEXDocument.New_CAEXDocument());
            ShowResult(document, "Relations.CreateSystemUnitClassInstance");
            Relations.CreateInterfaceClassInstance(document = CAEXDocument.New_CAEXDocument());
            ShowResult(document, "Relations.CreateInterfaceClassInstance");
        }

        private static void CreateCommunication ()
        {
            _editorChannel = new CommunicationChannel("AMLEngine Wiki", null, OnReceived, OnTerminated);
        }

        private static void OnTerminated()
        {
            _editorChannel?.Close();
            _editorChannel = null;
        }

        private static void OnReceived(ResponseMessage msg)
        {
            Debug.WriteLine ($"{msg.Command.CommandType} {msg.Result}");
        }

        private static CommunicationChannel _editorChannel;

        private static void ShowResult(CAEXDocument document, string method)
        {
            Console.Write($"Show Result of {method}");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($" Y/N?");
            var answer = Console.ReadKey().KeyChar;

            if (answer=='y' || answer== 'Y')
            {
                document.SaveToFile($"{method}.aml", true);
                ShowFile(method, document);
                System.Threading.Thread.Sleep(5000);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void ShowFile (string method, CAEXDocument document)
        {
            if (_editorChannel == null)
            {
                CreateCommunication();
            }
            _editorChannel.SendNote($"{method} - example.");
            _editorChannel.SendCommand(EditorComandEnum.OpenDocumentCommand,
                System.IO.Path.GetFullPath($"{method}.aml"));

            string caexPath=null;

            foreach (var lib in document.CAEXFile)
            {
                caexPath=lib.CAEXPath();

                if (caexPath != null)
                {
                    _editorChannel.SendCommand(EditorComandEnum.SetActiveHierarchyCommand, CAEX_CLASSModel_TagNames.SYSTEMUNITCLASSLIB_STRING);
                    // _editorChannel.SendCommand(EditorComandEnum.SelectByPathCommand, caexPath);
                    _editorChannel.SendCommand(EditorComandEnum.ExpandByPathCommand, caexPath);
                }
            }
        }
    }
}