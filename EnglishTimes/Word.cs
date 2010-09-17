namespace Hazzik.FluentEnglishTimes
{
	public class Word
	{
		private readonly string word;

		public Word(string word)
		{
			this.word = word;
		}

		public virtual string ToString(SentenceState state)
		{
			return word;
		}
	}
}