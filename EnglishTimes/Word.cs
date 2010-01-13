namespace Hazzik.FluentEnglishTimes
{
	public class Word
	{
		private readonly string _word;

		public Word(string word)
		{
			_word = word;
		}

		public override string ToString()
		{
			return _word;
		}
	}
}