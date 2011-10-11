namespace Hazzik.FluentEnglishTimes
{
	public class Word
	{
		private readonly string word;

		public Word(string word)
		{
			this.word = word;
		}

		public override string ToString()
		{
			return word;
		}
	}
}