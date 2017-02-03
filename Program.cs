using System;
using System.Text;

namespace ashr.net.hacktools
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length < 1) {
				showUsage ();
			}

			int length = int.Parse (args [0]);
			Console.WriteLine (new OffsetFinder().GeneratePattern(length));
		}



		private static void showUsage(){
			Console.WriteLine ("pattern_create stringlength (pattern_create 1024)");
		}
	}
}
