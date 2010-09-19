using System.Collections.Generic;
using System.Linq;

namespace Hazzik.FluentEnglishTimes
{
	public static class SentenceFactory
	{
		public static Sentence CreateSentence(string sentence)
		{
			return new Sentence(Parse(sentence));
		}

		private static List<Word> Parse(string sentence)
		{
			return sentence.Split(' ')
				.Select((word, index) => index == 1 ? Verb.Create(word) : new Word(word))
				.ToList();
		}
	}
}