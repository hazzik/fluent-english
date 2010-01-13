using Xunit;

namespace Hazzik.FluentEnglishTimes.Test
{
	public class FutureInThePast
	{
		[Fact]
		public void Simple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");
			sentence.Future().Past();
			string str = sentence.ToString();
			Assert.Equal("I should do it", str);
		}

		[Fact]
		public void Progressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");
			sentence.Progressive().Future().Past();

			string str = sentence.ToString();

			Assert.Equal("I should be doing it", str);
		}

		[Fact]
		public void Perfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");
			sentence.Perfect().Future().Past();

			string str = sentence.ToString();

			Assert.Equal("I should have done it", str);
		}

		[Fact]
		public void PerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");
			sentence.Progressive().Perfect().Future().Past();

			string str = sentence.ToString();

			Assert.Equal("I should have been doing it", str);
		}
	}
}