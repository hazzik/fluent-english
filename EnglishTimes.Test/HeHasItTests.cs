using Xunit;

namespace Hazzik.FluentEnglishTimes.Test
{
	public class HeHasItTests
	{
		[Fact]
		public void PresentSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He has it");

			string @string = sentence.ToString();

			Assert.Equal("He has it", @string);
		}

		[Fact]
		public void PresentProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He has it");

			sentence.Progressive();

			string str = sentence.ToString();

			Assert.Equal("He is having it", str);
		}

		[Fact]
		public void PresentPerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He has it");

			sentence.Perfect();

			string str = sentence.ToString();

			Assert.Equal("He has had it", str);
		}

		[Fact]
		public void PresentPerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He has it");

			sentence.Progressive().Perfect();

			string str = sentence.ToString();

			Assert.Equal("He has been having it", str);
		}

		[Fact]
		public void FutureSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He has it");

			sentence.Future();

			string str = sentence.ToString();

			Assert.Equal("He will have it", str);
		}

		[Fact]
		public void FutureProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He has it");

			sentence.Progressive().Future();

			string str = sentence.ToString();

			Assert.Equal("He will be having it", str);
		}

		[Fact]
		public void FuturePerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He has it");

			sentence.Perfect().Future();

			string str = sentence.ToString();

			Assert.Equal("He will have had it", str);
		}

		[Fact]
		public void FuturePerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He has it");

			sentence.Progressive().Perfect().Future();

			string str = sentence.ToString();

			Assert.Equal("He will have been having it", str);
		}

		[Fact]
		public void PastSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He has it");

			sentence.Past();

			string str = sentence.ToString();

			Assert.Equal("He had it", str);
		}

		[Fact]
		public void PastProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He has it");

			sentence.Progressive().Past();

			string str = sentence.ToString();

			Assert.Equal("He was having it", str);
		}

		[Fact]
		public void PastPerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He has it");

			sentence.Perfect().Past();

			string str = sentence.ToString();

			Assert.Equal("He had had it", str);
		}

		[Fact]
		public void PastPerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("He has it");

			sentence.Progressive().Perfect().Past();

			string str = sentence.ToString();

			Assert.Equal("He had been having it", str);
		}
	}
}