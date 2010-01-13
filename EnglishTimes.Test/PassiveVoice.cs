using System;
using Xunit;

namespace Hazzik.FluentEnglishTimes.Test
{
	public class PassiveVoice
	{
		[Fact]
		public void Simple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do by it");
			sentence.Passive();
			string str = sentence.ToString();
			Assert.Equal("I am done by it", str);
		}

		[Fact]
		public void Progressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do by it");
			sentence.Passive().Progressive();
			string str = sentence.ToString();
			Assert.Equal("I am being done by it", str);
		}

		[Fact]
		public void Perfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do by it");
			sentence.Passive().Perfect();
			string str = sentence.ToString();
			Assert.Equal("I have been done by it", str);
		}

		[Fact]
		public void PerfectProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do by it");
			Assert.Throws<NotSupportedException>(() => sentence.Passive().Progressive().Perfect());
		}

		[Fact]
		public void PastSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do by it");
			sentence.Passive().Past();
			string str = sentence.ToString();
			Assert.Equal("I was done by it", str);
		}

		[Fact]
		public void PastProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do by it");
			sentence.Passive().Progressive().Past();
			string str = sentence.ToString();
			Assert.Equal("I was being done by it", str);
		}

		[Fact]
		public void PastPerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do by it");
			sentence.Passive().Perfect().Past();
			string str = sentence.ToString();
			Assert.Equal("I had been done by it", str);
		}

		[Fact]
		public void FutureSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do by it");
			sentence.Passive().Future();
			string str = sentence.ToString();
			Assert.Equal("I shall be done by it", str);
		}

		[Fact]
		public void FutureProgressive()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do by it");
			Assert.Throws<NotSupportedException>(() => sentence.Passive().Progressive().Future());
		}

		[Fact]
		public void FuturePerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do by it");
			sentence.Passive().Perfect().Future();
			string str = sentence.ToString();
			Assert.Equal("I shall have been done by it", str);
		}

		[Fact]
		public void FutureInThePastSimple()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do by it");
			sentence.Passive().Future().Past();
			string str = sentence.ToString();
			Assert.Equal("I should be done by it", str);
		}

		[Fact]
		public void FutureInThePastPerfect()
		{
			Sentence sentence = SentenceFactory.CreateSentence("I do by it");
			sentence.Passive().Perfect().Future().Past();
			string str = sentence.ToString();
			Assert.Equal("I should have been done by it", str);
		}
	}
}