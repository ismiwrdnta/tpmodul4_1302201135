using System;
using System.Collections;
using System.Collections.Generic;

namespace tpmodul4_1302201135
{
	public class HaloGeneric
	{
		public static void SapaUser<T> (T a)
		{
			Console.WriteLine("Hallo user " + a + "!");
		}
	}

}
