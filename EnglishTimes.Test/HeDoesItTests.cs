using Xunit;

namespace Hazzik.FluentEnglishTimes.Test
{
	public class HeDoesItTests
	{
		[Fact]
		public void PresentSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He does it");

			string @string = sentence.ToString();

			Assert.Equal("He does it", @string);
		}

		[Fact]
		public void PresentProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He does it");

			sentence.Progressive();

			string str = sentence.ToString();

			Assert.Equal("He is doing it", str);
		}

		[Fact]
		public void PresentPerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He does it");

			sentence.Perfect();

			string str = sentence.ToString();

			Assert.Equal("He has done it", str);
		}

		[Fact]
		public void PresentPerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He does it");

			sentence.Progressive().Perfect();

			string str = sentence.ToString();

			Assert.Equal("He has been doing it", str);
		}

		[Fact]
		public void FutureSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He does it");

			sentence.Future();

			string str = sentence.ToString();

			Assert.Equal("He will do it", str);
		}

		[Fact]
		public void FutureProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He does it");

			sentence.Progressive().Future();

			string str = sentence.ToString();

			Assert.Equal("He will be doing it", str);
		}

		[Fact]
		public void FuturePerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He does it");

			sentence.Perfect().Future();

			string str = sentence.ToString();

			Assert.Equal("He will have done it", str);
		}

		[Fact]
		public void FuturePerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He does it");

			sentence.Progressive().Perfect().Future();

			string str = sentence.ToString();

			Assert.Equal("He will have been doing it", str);
		}

		[Fact]
		public void PastSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He does it");

			sentence.Past();

			string str = sentence.ToString();

			Assert.Equal("He did it", str);
		}

		[Fact]
		public void PastProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He does it");

			sentence.Progressive().Past();

			string str = sentence.ToString();

			Assert.Equal("He was doing it", str);
		}

		[Fact]
		public void PastPerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He does it");

			sentence.Perfect().Past();

			string str = sentence.ToString();

			Assert.Equal("He had done it", str);
		}

		[Fact]
		public void PastPerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He does it");

			sentence.Progressive().Perfect().Past();

			string str = sentence.ToString();

			Assert.Equal("He had been doing it", str);
		}
	}
}