namespace Quiz
{
	public class Questions
	{
		public static List<Program.Quiz> GetQuestions()
		{
			List<Program.Quiz> questions = new List<Program.Quiz>()
			{
				{ new Program.Quiz("Who is Bjarne Stristrup", ["The creator of Python", "The creator of Java", "The creator of C#", "The creator of C++"], "The creator of C++") },
				{ new Program.Quiz("Quem é doc?", ["Gênio do python", "Vagabundo", "doido", "lindo"], "doido") },
				{ new Program.Quiz("True or false?", ["true", "false"], "true") },
				{ new Program.Quiz("Which number is the greatest?", ["1", "2", "3", "4", "5"], "5") }
			};

			return questions;
		}
	}
}
