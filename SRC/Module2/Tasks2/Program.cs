using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks2 {
	class Program {
		static void Main(string[] args) {
			var cs = new CancellationTokenSource();
			var ct = cs.Token;

			var task1 = new Task(() => {
				while (true) {
					var input = Console.ReadKey(true);
					if (input.Key == ConsoleKey.Escape) {
						cs.Cancel();
						break;
					}
				}
			});

			var task2 = new Task(() => {
				while (true) {
					Thread.Sleep(2000);
					Console.WriteLine("Task still running.");
					//	if (ct.IsCancellationRequested) break;
					ct.ThrowIfCancellationRequested();
				}
			}, ct);

			try {
				task1.Start();
				task2.Start();
				task2.Wait();
			}
			catch {
				if (task2.IsCanceled)
					Console.WriteLine("Task was cancelled.");
				else Console.WriteLine("Error occurred in the task.");
			}
			finally {
				Console.WriteLine(task1.IsCompleted);
				Console.WriteLine(task2.IsCompleted);
			}
		}
	}
}
