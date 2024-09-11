﻿namespace Quiz
{
	public class Program
	{
		public class Quiz
		{
			public string Question { get; set; }
			public string[] Answers { get; set; }
			public string CorrectAnswer {  get; set; }

			public Quiz(string question, string[] answers, string correctAnswer)
			{
				Question = question;
				Answers = answers;
				CorrectAnswer = correctAnswer;
			}
		}

		static void Main()
		{
			List<Quiz> question = Questions.GetQuestions();

			int randomIndex = new Random().Next(0, question.Count);

			Console.WriteLine(question[randomIndex].Question + "\n");

			char[] options = ['A', 'B', 'C', 'D'];
			for (int i = 0; i < question[randomIndex].Answers.Length; i++)
			{
				Console.WriteLine($"{options[i]}. {question[randomIndex].Answers[i]}");
			}
			Console.Write("\nAnswer: ");
			string userAnswer = Console.ReadLine()!.ToLower();

			bool isValidAnswer = userAnswer.All<char>(c => "abcd".Contains(c));
			if (userAnswer.Length <= 0 || userAnswer.Length >= 2 || !isValidAnswer)
			{
				Console.WriteLine("Invalid answer");
				Environment.Exit(0);
			}

			switch (userAnswer) 
			{
				case "a":
					userAnswer = question[randomIndex].Answers[0];
					break;
				case "b":
					userAnswer = question[randomIndex].Answers[1];
					break;
				case "c":
					userAnswer = question[randomIndex].Answers[2];
					break;
				case "d":
					userAnswer = question[randomIndex].Answers[3];
					break;
				default:
					Console.WriteLine("Invalid somehow.");
					break;
			}

			if(userAnswer != question[randomIndex].CorrectAnswer)
			{
				Console.WriteLine($"Wrong! The correct answer was: {options[Array.FindIndex(question[randomIndex].Answers, w => w == question[randomIndex].CorrectAnswer)]}. {question[randomIndex].CorrectAnswer}");
				Environment.Exit(0);
			}

			Console.WriteLine("You are correct!");
		}
	}
}