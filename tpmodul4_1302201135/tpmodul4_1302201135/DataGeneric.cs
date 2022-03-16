using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpmodul4_1302201135
{
	public class DataGeneric<T>
	{
		private T data;
		public DataGeneric(T data)
        {
			this.data = data;
		}

		public void PrintData()
        {
			Console.WriteLine("Data yang tersimpan adalah " + this.data);
        }
	}
}


