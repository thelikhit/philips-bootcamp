using System;

namespace Examples {
	public class Array<T> {
		public static void Resize(ref T[] source, int reSize) {
			T[] temp = new T[reSize];
			for (int i = 0; i < source.Length; i++) {
				temp[i] = source[i];
			}
			source = temp;
		}
	}

	public class DynamicArray<T> {
		
		T[] buffer = new T[5];
		private int itemCount;
		
		public T this[int index] {
			set {
				itemCount++;
				if (index >= buffer.Length) {
					Array.Resize(ref buffer, index + 10);
				}
				buffer[index] = value;
			}
			
			get {
				return buffer[index];
			}
		}

		public int ItemsCount {
			get {
				return itemCount;
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
			
			DynamicArray<int> intArray = new DynamicArray<int>();
			
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
			int intVal = intArray[8];

			Console.WriteLine(intVal);
			Console.WriteLine(intArray.ItemsCount);
			Console.WriteLine(intArray.Capacity);
			
			// =======================================================================
		
			DynamicArray<double> doubleArray = new DynamicArray<double>();
			
			doubleArray[0] = 10.1;
			doubleArray[1] = 20.2;
			doubleArray[2] = 30.3;
			doubleArray[3] = 40.4;
			doubleArray[4] = 50.5;
			doubleArray[5] = 60.6;
			doubleArray[6] = 70.7;
			doubleArray[7] = 80.8;
			doubleArray[8] = 90.9;
			doubleArray[9] = 100.1;
			double doubleVal = doubleArray[8];

			Console.WriteLine(doubleVal);
			Console.WriteLine(doubleArray.ItemsCount);
			Console.WriteLine(doubleArray.Capacity);
			
			
		}
	}
}
