using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks1 {
	class Program {
		static void Main(string[] args) {
			Task task1 = new Task(() => {
				Console.WriteLine("Task 1");
				Thread.Sleep(4000);
				Console.WriteLine("Task 1 completed.");
			});
			Task task2 = new Task(() => {
				Console.WriteLine("Task 2");
				Thread.Sleep(4000);
				Console.WriteLine("Task 2 completed.");
			});
			Task task3 = new Task(() => {
				Console.WriteLine("Task 3");
				Thread.Sleep(4000);
				Console.WriteLine("Task 3 completed.");
			});

			task1.Start();
			Thread.Sleep(2000);
			task2.Start();
			Thread.Sleep(2000);
			task3.Start();
			//	task1.Wait();
			//	task2.Wait();
			//	task3.Wait();
			//	Task.WaitAll(task1, task2, task3);
			//	Task.WaitAny(task1, task2, task3);
			var taskGroup1 = Task.WhenAll(task1, task2, task3);
			var taskGroup2 = Task.WhenAny(task1, task2, task3);
			taskGroup2.Wait();
			Console.WriteLine("One of the tasks completed.");
			taskGroup1.Wait();
			Console.WriteLine("All the tasks completed.");

			var task4 = new Task<int>(() => {
				Console.WriteLine("Task 4");
				Thread.Sleep(4000);
				Console.WriteLine("Task 4 completed.");
				return 123;
			});
			task4.Start();
			task4.Wait();
			Console.WriteLine(task4.Result);

			Console.WriteLine("Finish");

		}
	}
}
