using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel2 {
	class Program {
		static void Task1() {
			Console.WriteLine("Task 1");
			Thread.Sleep(4000);
		}
		static void Task2() {
			Console.WriteLine("Task 2");
			Thread.Sleep(4000);
		}
		static void Task3() {
			Console.WriteLine("Task 3");
			Thread.Sleep(4000);
		}
		static void Main(string[] args) {
			//Parallel.Invoke(
			//	() => { Console.WriteLine("Task 1"); Thread.Sleep(4000); },
			//	() => { Console.WriteLine("Task 2"); Thread.Sleep(4000); },
			//	() => { Console.WriteLine("Task 3"); Thread.Sleep(4000); }
			//);
			// Parallel.Invoke(Task1, Task2, Task3);
			Action[] tasks = {
				Task1,
				Task2,
				Task3
			};
			Parallel.Invoke(tasks);
			Console.WriteLine("Finish");
		}
	}
}
