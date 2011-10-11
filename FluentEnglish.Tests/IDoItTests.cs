using Xunit;

namespace Hazzik.FluentEnglishTimes.Test
{
// ReSharper disable InconsistentNaming
	public class IDoItTests
	{
// ReSharper restore InconsistentNaming
		[Fact]
		public void PresentSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");

			string @string = sentence.ToString();

			Assert.Equal("I do it", @string);
		}

		[Fact]
		public void PresentProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");

			sentence.Progressive();

			string str = sentence.ToString();

			Assert.Equal("I am doing it", str);
		}

		[Fact]
		public void PresentPerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");

			sentence.Perfect();

			string str = sentence.ToString();

			Assert.Equal("I have done it", str);
		}

		[Fact]
		public void PresentPerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");

			sentence.Progressive().Perfect();

			string str = sentence.ToString();

			Assert.Equal("I have been doing it", str);
		}

		[Fact]
		public void FutureSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");

			sentence.Future();

			string str = sentence.ToString();

			Assert.Equal("I shall do it", str);
		}

		[Fact]
		public void FutureProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");

			sentence.Progressive().Future();

			string str = sentence.ToString();

			Assert.Equal("I shall be doing it", str);
		}

		[Fact]
		public void FuturePerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");

			sentence.Perfect().Future();

			string str = sentence.ToString();

			Assert.Equal("I shall have done it", str);
		}

		[Fact]
		public void FuturePerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");

			sentence.Progressive().Perfect().Future();

			string str = sentence.ToString();

			Assert.Equal("I shall have been doing it", str);
		}

		[Fact]
		public void PastSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");

			sentence.Past();

			string str = sentence.ToString();

			Assert.Equal("I did it", str);
		}

		[Fact]
		public void PastProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");

			sentence.Progressive().Past();

			string str = sentence.ToString();

			Assert.Equal("I was doing it", str);
		}

		[Fact]
		public void PastPerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");

			sentence.Perfect().Past();

			string str = sentence.ToString();

			Assert.Equal("I had done it", str);
		}

		[Fact]
		public void PastPerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do it");

			sentence.Progressive().Perfect().Past();

			string str = sentence.ToString();

			Assert.Equal("I had been doing it", str);
		}
	}
}