using System;
using System.Text;

namespace pattern_create
{
	public class OffsetFinder
	{
		public OffsetFinder (){}

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

		public string GeneratePattern(int Length){
			StringBuilder output = new StringBuilder ();

			while (output.Length < Length) {
				output.Append (getNextNumber ());
			}

			return (output.ToString ().Substring(0,Length));			
		}

		public int FindOffset(string Pattern, int Length){
			throw new NotImplementedException ();
		}
	}
}

