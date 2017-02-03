using System;
using System.Text;

namespace pattern_create
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length < 1) {
				showUsage ();
			}

			int length = int.Parse (args [0]);
			StringBuilder output = new StringBuilder ();

			while (output.Length < length) {
				output.Append (getNextNumber ());
			}

			Console.WriteLine (output.ToString ().Substring(0,length));
		}

		static char currentFirst = 'Z';
		static char currentSecond ='z';
		static int currentThird = 9;

		private static string getNextNumber(){
			char incCurrentFirst = currentFirst;//(char)((int)currentFirst + 1);
			char incCurrentSecond = currentSecond;//(char)((int)currentSecond + 1);
			int incCurrentThird = ++currentThird;

			if (incCurrentThird > 9) {
				incCurrentThird = 0;

				incCurrentSecond = (char)((int)currentSecond + 1);
					
				if (((int)incCurrentSecond) > ((int)'z')) {
					incCurrentSecond = 'a';

					incCurrentFirst = (char)((int)currentFirst + 1);
						
					if (((int)incCurrentFirst) > ((int)'Z')) {
						incCurrentFirst = 'A';
					}
				}
			}

			currentFirst = incCurrentFirst;
			currentSecond = incCurrentSecond;
			currentThird = incCurrentThird;

			return incCurrentFirst.ToString() + incCurrentSecond.ToString() + incCurrentThird.ToString ();
		}

		private static void showUsage(){
			Console.WriteLine ("pattern_create stringlength (pattern_create 1024)");
		}
	}
}
