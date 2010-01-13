using System.Collections.Generic;

namespace Hazzik.FluentEnglishTimes
{
	public class SentenceFactory
	{
		public static Sentence CreateSentence(string sentence)
		{
			return new Sentence(Parse(sentence));
		}

		private static List<Word> Parse(string sentence)
		{
			var words = new List<Word>();
			int i = 0;
			foreach (string w in sentence.Split(' '))
			{
				Word word;
				if (i != 1) word = new Word(w);
				else
				{
					if (w == "does")
					{
						word = Verb.Create("do");
					}
					else if (w == "am")
					{
						word = Verb.Create("be");
					}
					else
					{
						word = Verb.Create(w);
					}
				}
				i++;
				words.Add(word);
			}
			return words;
		}
	}
}