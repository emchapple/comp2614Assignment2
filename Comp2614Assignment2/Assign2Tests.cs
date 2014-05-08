using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;
using NUnit.Framework.Constraints;
using System;
using System.IO;

namespace Comp2614Assignment2
{
	[TestFixture ()]
	public class Assign2Teests
	{
		[Test ()]
		public void GetFileName ()
		{
			string[] args = {"invoicedata.txt"};
			Program.SetFileName (args);
			Assert.AreEqual (args [0], Program.FILENAME);


		}

		[Test ()]
		public void GetFileNameTwoArgs ()
		{
			string[] args = {"invoicedata.txt", "some other crap"};
			Program.SetFileName (args);
			Assert.AreEqual (args [0], Program.FILENAME);


		}

		[Test ()]
		public void GetFileNameEmpty ()
		{
			string[] args = null;
			bool success = Program.SetFileName (args);
			Assert.IsFalse (success);

		}


		[Test ()]
		public void CheckValidFilename ()
		{
			string[] args = {"../../../invoicedata.txt"};
			Program.SetFileName (args);
			Assert.IsNotNull (Program.GetFileStream());
		}





		[Test ()]
		public void CheckInvalidFilename ()
		{
			string[] args = {"zork.txt"};
			Program.SetFileName (args);
			Assert.IsNull (Program.GetFileStream());
		}







	}
}

