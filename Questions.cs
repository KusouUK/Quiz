using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
	public class Questions
	{
		public static List<Program.Quiz> GetQuestions()
		{
			List<Program.Quiz> question = new List<Program.Quiz>();
			question.Add(new Program.Quiz("Who is Bjarne Stroustrup?", ["The creator of Python", "The creator of Java", "The creator of C#", "The creator of C++"], "The creator of C++"));
			question.Add(new Program.Quiz("Quem é doc?", ["Gênio do python", "Vagabundo", "doido", "lindo"], "doido"));
			return question;
		}
	}
}
