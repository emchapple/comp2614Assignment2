using System;
using System.IO;

namespace Comp2614Assignment2
{
	public class Program
	{
		public static string FILENAME;

		public Program ()
		{
		}


		public static void Main(string[] args)
		{
			bool success = SetFileName (args);
			if (success)
			{
				GetFileStream ();
				//ProcessFile ();
			} else
			{
				Console.WriteLine ("Please specify the filename as a command line argument.");
			}

		}


		public static bool SetFileName(string[] args)
		{
			if (args != null && args.Length > 0 && args [0] != null)
			{
				FILENAME = args [0];
				Console.WriteLine (FILENAME);
				return true;
			} else
			{

				return false;
			}
		}

		public static StreamReader GetFileStream()
		{
			try
			{
				return new StreamReader (FILENAME);
			} catch(Exception ex)
			{
				Console.WriteLine (ex.Message);
				return null;
			}
			finally
			{
				Console.WriteLine ("done");
			}

		}



	}
}

