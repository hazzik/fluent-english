using Xunit;

namespace Hazzik.FluentEnglishTimes.Test
{
	public class YouDoItTests
	{
		[Fact]
		public void PresentSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("You do it");

			string @string = sentence.ToString();

			Assert.Equal("You do it", @string);
		}

		[Fact]
		public void PresentProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("You do it");

			sentence.Progressive();

			string str = sentence.ToString();

			Assert.Equal("You are doing it", str);
		}

		[Fact]
		public void PresentPerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("You do it");

			sentence.Perfect();

			string str = sentence.ToString();

			Assert.Equal("You have done it", str);
		}

		[Fact]
		public void PresentPerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("You do it");

			sentence.Progressive().Perfect();

			string str = sentence.ToString();

			Assert.Equal("You have been doing it", str);
		}

		[Fact]
		public void FutureSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("You do it");

			sentence.Future();

			string str = sentence.ToString();

			Assert.Equal("You will do it", str);
		}

		[Fact]
		public void FutureProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("You do it");

			sentence.Progressive().Future();

			string str = sentence.ToString();

			Assert.Equal("You will be doing it", str);
		}

		[Fact]
		public void FuturePerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("You do it");

			sentence.Perfect().Future();

			string str = sentence.ToString();

			Assert.Equal("You will have done it", str);
		}

		[Fact]
		public void FuturePerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("You do it");

			sentence.Progressive().Perfect().Future();

			string str = sentence.ToString();

			Assert.Equal("You will have been doing it", str);
		}

		[Fact]
		public void PastSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("You do it");

			sentence.Past();

			string str = sentence.ToString();

			Assert.Equal("You did it", str);
		}

		[Fact]
		public void PastProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("You do it");

			sentence.Progressive().Past();

			string str = sentence.ToString();

			Assert.Equal("You were doing it", str);
		}

		[Fact]
		public void PastPerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("You do it");

			sentence.Perfect().Past();

			string str = sentence.ToString();

			Assert.Equal("You had done it", str);
		}

		[Fact]
		public void PastPerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("You do it");

			sentence.Progressive().Perfect().Past();

			string str = sentence.ToString();

			Assert.Equal("You had been doing it", str);
		}
	}
}