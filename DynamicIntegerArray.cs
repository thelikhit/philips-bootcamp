using System;

namespace Examples{
	public class Array {
		public static void Resize(ref int[] source, int reSize) {
			int[] temp = new int[reSize];
			for (int i = 0; i < source.Length; i++) {
				temp[i] = source[i];
			}
			source = temp;
		}
	}

	public class DynamicIntegerArray {
		
		private int[] buffer = new int[5];
		private int itemCnt;
		public int this[int index] {
			
			set {
				itemCnt++;
				if (index >= buffer.Length) {
					Array.Resize(ref buffer, index + 10);
				}
				buffer[index] = value;
			}
			
			get {
				return buffer[index];
			}
		}

		public void Clear()
		{ }

		public int ItemsCnt {
			get {
				return itemCnt;
			}
		}

		public int Capacity {
			get {
				return buffer.Length;
			}
		}
	}

	public class Program {
		
		public static void Main() {
			
			DynamicIntegerArray intArray = new DynamicIntegerArray();

			intArray[0] = 10;
			intArray[1] = 20;
			intArray[2] = 30;
			intArray[3] = 40;
			intArray[4] = 50;
			intArray[5] = 60;
			intArray[6] = 70;
			intArray[7] = 80;
			intArray[8] = 90;
			intArray[9] = 100;
			int val = intArray[8];

			Console.WriteLine(val);
			Console.WriteLine(intArray.ItemsCnt);
			Console.WriteLine(intArray.Capacity);
		}
	}
}
