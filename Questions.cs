namespace Quiz
{
	public class Questions
	{
		public static List<Program.Quiz> GetQuestions()
		{
			List<Program.Quiz> question = new List<Program.Quiz>();
			question.Add(new Program.Quiz("Who is Bjarne Stroustrup?", ["The creator of Python", "The creator of Java", "The creator of C#", "The creator of C++"], "The creator of C++"));
			question.Add(new Program.Quiz("Quem é doc?", ["Gênio do python", "Vagabundo", "doido", "lindo"], "doido"));
			question.Add(new Program.Quiz("True or false?", ["true", "false"], "true"));
			question.Add(new Program.Quiz("Which number is the greatest?", ["1", "2", "3", "4", "5"], "5"));

			return question;
		}
	}
}
