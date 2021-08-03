using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Aml.Engine.AmlObjects;
using Aml.Engine.CAEX;
using Aml.Engine.CAEX.Extensions;
using Aml.Engine.Services;
using Aml.Engine.Xml.Extensions;

namespace WindowsFormsApplication1
{
	/// <summary>
	/// This application is a demonstrator for basic AML engine functions
	/// </summary>
	public partial class Form1 : Form
	{
		private CAEXDocument _myDoc;
		private string _fileName;

		public Form1()
		{
			InitializeComponent();
		}


		/// <summary>
		/// Loads a CAEX file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Btn_OpenCAEX_Click(object sender, EventArgs e)
		{
			myErrorListBox.Items.Clear();
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			_myDoc = null;
			CAEXTreeView.Nodes.Clear();
			_fileName = openFileDialog.FileName;
			lbl_FileName.Text = _fileName;
			_myDoc = CAEXDocument.LoadFromFile(_fileName);
			ShowMyTree(CAEXTreeView, _myDoc);
		}

		/// <summary>
		/// Creates an example CAEX file
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Btn_CreateCAEX_Click(object sender, EventArgs e)
		{
			myErrorListBox.Items.Clear();
			CAEXTreeView.Nodes.Clear();

			// Create a new CAEX document
			_myDoc = CAEXDocument.New_CAEXDocument();

			// ***************************
			// ******** SystemUnitClass 
			// ***************************

			// Create a set of SystemUnitClassLibs
			var sucLib1 = _myDoc.CAEXFile.SystemUnitClassLib.Append();
			sucLib1.Name = "MySUCLib";
			var sucLib2 = _myDoc.CAEXFile.SystemUnitClassLib.Append();
			sucLib2.Name = "MySUCLib1";
			var sucLib3 = _myDoc.CAEXFile.SystemUnitClassLib.Append();
			sucLib3.Name = "MySUCLib2";

			// Create a new SystemUnitClass
			var suc = sucLib1.SystemUnitClass.Append();
			suc.Name = "Class MyTank";

			// Create another SystemUnitClass
			var suc1 = sucLib1.SystemUnitClass.Append();
			suc1.Name = "Class MyLid";

			// Create a nested InternalElement within the SystemUnitClass "MyTank"
			var sucIntElem1 = suc.InternalElement.Append();
			sucIntElem1.Name = "IE MyGround";

			// Create an instance of the "MyLid" within the SystemUnitClass "MyTank"
			var sucIntElem2 = suc1.CreateClassInstance();
			sucIntElem2.Name = "Instance of class MyLid";
			suc.InternalElement.Insert(sucIntElem2);

			// Create a list with all SystemUnitClassLibs with the name "MySUCLib"
			var exampleSucLibList = _myDoc.CAEXFile.SystemUnitClassLib.Where(x => "MySUCLib".Equals(x.Name));
			Debug.Assert(exampleSucLibList.Count() == 1, nameof(exampleSucLibList) + " != 1");

			// ***************************
			// ******** RoleClasses
			// ***************************

			var roleClassLib = _myDoc.CAEXFile.RoleClassLib.Append();
			roleClassLib.Name = "MyRoleLib";
			var roleClass = roleClassLib.RoleClass.Append();
			roleClass.Name = "Role Lid";

			// ***************************
			// ******** InstanceHierarchy 
			// ***************************

			// Create a new InstanceHierarchy
			var insHierarchy = _myDoc.CAEXFile.InstanceHierarchy.Append();
			insHierarchy.Name = "MyHierarchy";

			// Set change mode
			insHierarchy.ChangeMode = ChangeMode.Change;
			Debug.Assert(ChangeMode.Change == insHierarchy.ChangeMode, nameof(insHierarchy) + "does not have the correct change mode");

			// Create a new InternalElement
			var intElem = insHierarchy.InternalElement.Append();
			intElem.Name = "IE";
			intElem.ID = "GUID1";
			intElem.Description = "Another description";

			// Get CAEX instance path
			var intElemPath = intElem.CAEXPath();
			Debug.Assert("GUID1".Equals(intElemPath), nameof(intElemPath) + " is not correct");

			// Create a new role requirement
			var roleReq = intElem.RoleRequirements.Append();
			roleReq.RefBaseRoleClassPath = roleClass.GetFullNodePath();

			// Create a new attribute
			var att = intElem.Attribute.Append();
			att.Name = "Weight";
			att.Value = "20";
			att.Unit = "t";

			// Check if attribute exists
			att = intElem.Attribute.FirstOrDefault(x => "Weight".Equals(x.Name));
			Debug.Assert(att != null, nameof(att) + " != null");

			// Set attribute values
			intElem.SetAttributeValue("Weight", "21");
			intElem.SetAttributeValue("Mass1", "11");

			// Check if attribute value set
			var attValue = att.Value;
			Debug.Assert("21".Equals(attValue), nameof(attValue) + " != 21");

			var massAtt = intElem.Attribute["Mass1"];
			var massAttValue = massAtt.Value;
			Debug.Assert("11".Equals(massAttValue), nameof(attValue) + " != 11");

			// Create a new InternalElement intElem2

			var intElem2 = insHierarchy.InternalElement.Append();
			intElem2.Name = "IE2";

			var att2 = intElem2.Attribute.Append();
			att2.Name = "Color";
			att2.Value = "Yellow";

			// Delete the new attribute
			att2.Remove();
			Debug.Assert(!intElem2.Attribute.Contains(att2), nameof(att2) + " exists");
		
			// Create a new InternalElement IE5
			var intElem5 = intElem2.InternalElement.Append();
			intElem5.Name = "IE5";

			// Delete the InternalElement IE5
			intElem5.Remove();

			// Set source document information
			var sourceDocInfo = _myDoc.CAEXFile.SourceDocumentInformation[0];
			sourceDocInfo.OriginName = "WriterName";
			sourceDocInfo.OriginID = "WriterID";
			sourceDocInfo.OriginVendor = "WriterVendor";
			sourceDocInfo.OriginVendorURL = "www.writervendor.com";
			sourceDocInfo.OriginVersion = "WriterVersion";
			sourceDocInfo.OriginRelease = "WriterRelease";
			sourceDocInfo.OriginProjectID = "WriterProjectID";
			sourceDocInfo.OriginProjectTitle = "WriterProjectTitle";
			sourceDocInfo.LastWritingDateTime = DateTime.Now;

			// Create revision element
			var rev = intElem.New_Revision(DateTime.Now, "Peter Mustermann");
			Debug.Assert(rev != null, nameof(rev) + " != null");

			rev.RevisionDate = DateTime.Now;
			rev.AuthorName = "Ender";
			rev.NewVersion = "1.2";
			rev.OldVersion = "1.1";
			rev.Comment = "A comment";

			// ********************************************
			// ******** Navigation specific AML operations
			// ********************************************

			// Creates a CAEX element from an XElement node
			var caexElement = new InternalElementType(intElem.Node);
			Debug.Assert(Equals(caexElement, intElem), nameof(caexElement) + " != " + nameof(intElem));

			// Another way of creating a CAEX element, without type information
			var abstractElement = intElem.Node.CreateCAEXWrapper();
			Debug.Assert(Equals(abstractElement, intElem), nameof(abstractElement) + " != " + nameof(intElem));

			// Finding the first ancestor of a specific type
			var firstAncestor = intElem.FirstAncestor<InstanceHierarchyType>();
			Debug.Assert(Equals(firstAncestor, insHierarchy), nameof(firstAncestor) + " != " + nameof(insHierarchy));

			// Gathering the name of the parent
			var parentName = intElem.GetParent<InstanceHierarchyType>().Name;
			Debug.Assert(Equals("MyHierarchy", parentName), nameof(parentName) + " != MyHierarchy ");

			// Finding element with the id
			var internalElementFromId = _myDoc.CAEXFile.FindCaexObjectFromId<InternalElementType>("GUID1");
			Debug.Assert(Equals(internalElementFromId, intElem), nameof(internalElementFromId) + " != " + nameof(intElem));

			// Finding element with the id without type information
			var elementFromId = _myDoc.FindByID("GUID1");
			Debug.Assert(Equals(elementFromId, intElem), nameof(elementFromId) + " != " + nameof(intElem));

			// Gathering descendants
			var descendantIntElem = insHierarchy.Descendants<InternalElementType>().FirstOrDefault(x => "GUID1".Equals(x.ID));
			Debug.Assert(Equals(descendantIntElem, intElem), nameof(descendantIntElem) + " != " + nameof(intElem));

			// Finding element with the path (is an ID for an instance)
			var intElementFromPath = _myDoc.CAEXFile.FindCaexObjectFromId<InternalElementType>(intElemPath);
			Debug.Assert(Equals(intElementFromPath, intElem), nameof(intElementFromPath) + " != " + nameof(intElem));
			
			// Finding element with the path without type information
			var abstractElemFromPath = _myDoc.FindByID(intElemPath);
			Debug.Assert(Equals(abstractElemFromPath, intElem), nameof(abstractElemFromPath) + " != " + nameof(intElem));

			ShowMyTree(CAEXTreeView, _myDoc);
		}

		/// <summary>
		/// Save CAEX-File
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Btn_SaveCAEX_Click(object sender, EventArgs e)
		{
			myErrorListBox.Items.Clear();
			saveFileDialog.Filter = @"AML files|*.aml";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			_fileName = saveFileDialog.FileName;
			_myDoc.SaveToFile(_fileName, true);
			_myDoc = CAEXDocument.LoadFromFile(_fileName);
		}

		/// <summary>
		/// Displays the CAEX file structure
		/// </summary>
		/// <param name="myTreeView"></param>
		/// <param name="doc"></param>
		private static void ShowMyTree(TreeView myTreeView, CAEXDocument doc)
		{
			foreach (var ih in doc.CAEXFile.InstanceHierarchy)
			{
				var node = myTreeView.Nodes.Add(ih.Name);
				node.Tag = ih;
				foreach (var ie in ih.InternalElement)
				{
					ShowMyInternalElement(node, ie);
				}
			}

			foreach (var rl in doc.CAEXFile.RoleClassLib)
			{
				var node = myTreeView.Nodes.Add(rl.Name);
				node.Tag = rl;
				foreach (var rc in rl.RoleClass)
				{
					ShowMyRoleClasses(node, rc);
				}
			}

			foreach (var sucl in doc.CAEXFile.SystemUnitClassLib)
			{
				var node = myTreeView.Nodes.Add(sucl.Name);
				node.Tag = sucl;
				foreach (var suc in sucl.SystemUnitClass)
				{
					ShowMySystemUnitClasses(node, suc);
				}
			}

		}

		private static void ShowMyInternalElement(TreeNode node, InternalElementType ie)
		{
			var childNode = node.Nodes.Add(ie.Name);
			childNode.Tag = ie;
			foreach (var childIe in ie.InternalElement)
			{
				ShowMyInternalElement(childNode, childIe);
			}
		}

		private static void ShowMyRoleClasses(TreeNode node, RoleFamilyType rc)
		{
			var childNode = node.Nodes.Add(rc.Name);
			childNode.Tag = rc;
			foreach (var childRc in rc.RoleClass)
			{
				ShowMyRoleClasses(childNode, childRc);
			}
		}

		private static void ShowMySystemUnitClasses(TreeNode node, SystemUnitFamilyType suc)
		{
			var childNode = node.Nodes.Add(suc.Name);
			childNode.Tag = suc;

			foreach (var ie in suc.InternalElement)
			{
				ShowMyInternalElement(childNode, ie);
			}
			foreach (var childSuc in suc.SystemUnitClass)
			{
				ShowMySystemUnitClasses(childNode, childSuc);
			}
		}

		private void Btn_ValidateCAEXFile_Click(object sender, EventArgs e)
		{
			if (_myDoc != null)
			{
				var isValid = _myDoc.Validate(out var errorMessages);
				if (isValid)
				{
					MessageBox.Show(@"Result of CAEX Validation" + Environment.NewLine + @"No Errors.", @"Validation Report");
				}
				else
				{
					foreach (var errorMessage in errorMessages)
					{
						myErrorListBox.Items.Add(errorMessage);
					}
					MessageBox.Show(@"Result of CAEX Validation" + Environment.NewLine + @"Number of Errors: " +
						errorMessages.Length + Environment.NewLine + @"Look into the error list.", @"Validation Report");
				}
			}
		}

		private void Btn_EtikettCAEXFile_Click(object sender, EventArgs e)
		{
			var sourceDocInfo = _myDoc.CAEXFile.SourceDocumentInformation[0];
			sourceDocInfo.OriginName = "A source tool";
			sourceDocInfo.OriginID = "A source tool";
			sourceDocInfo.OriginVendor = "A company";
			sourceDocInfo.OriginVendorURL = "www.acompany.com";
			sourceDocInfo.OriginVersion = "1.0";
			sourceDocInfo.OriginRelease = "1.0.1";
			sourceDocInfo.LastWritingDateTime = DateTime.Today;
			sourceDocInfo.OriginProjectTitle = "DemoProject";
			sourceDocInfo.OriginProjectID = "DemoProject";
		}

	}
}

