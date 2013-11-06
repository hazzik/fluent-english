using Xunit;

namespace Hazzik.FluentEnglishTimes.Test
{
    public class NegativeTests
    {
        [Fact]
        public void PresentSimple()
        {
            var sentence = SentenceFactory.CreateSentence("You do it");

            var @string = sentence.Negative().ToString();

            Assert.Equal("You do not do it", @string);
        }

        [Fact]
        public void PresentProgressive()
        {
            var sentence = SentenceFactory.CreateSentence("You do it");

            var str = sentence.Progressive().Negative().ToString();

            Assert.Equal("You are not doing it", str);
        }

        [Fact]
        public void PresentPerfect()
        {
            var sentence = SentenceFactory.CreateSentence("You do it");

            var str = sentence.Perfect().Negative().ToString();

            Assert.Equal("You have not done it", str);
        }

        [Fact]
        public void PresentPerfectProgressive()
        {
            var sentence = SentenceFactory.CreateSentence("You do it");

            var str = sentence.Progressive().Perfect().Negative().ToString();

            Assert.Equal("You have not been doing it", str);
        }

        [Fact]
        public void FutureSimple()
        {
            var sentence = SentenceFactory.CreateSentence("You do it");

            var str = sentence.Future().Negative().ToString();

            Assert.Equal("You will not do it", str);
        }

        [Fact]
        public void FutureProgressive()
        {
            var sentence = SentenceFactory.CreateSentence("You do it");

            var str = sentence.Progressive().Future().Negative().ToString();

            Assert.Equal("You will not be doing it", str);
        }

        [Fact]
        public void FuturePerfect()
        {
            var sentence = SentenceFactory.CreateSentence("You do it");

            var str = sentence.Perfect().Future().Negative().ToString();

            Assert.Equal("You will not have done it", str);
        }

        [Fact]
        public void FuturePerfectProgressive()
        {
            var sentence = SentenceFactory.CreateSentence("You do it");

            var str = sentence.Progressive().Perfect().Future().Negative().ToString();

            Assert.Equal("You will not have been doing it", str);
        }

        [Fact]
        public void PastSimple()
        {
            var sentence = SentenceFactory.CreateSentence("You do it");

            var str = sentence.Past().Negative().ToString();

            Assert.Equal("You did not do it", str);
        }

        [Fact]
        public void PastProgressive()
        {
            var sentence = SentenceFactory.CreateSentence("You do it");

            var str = sentence.Progressive().Past().Negative().ToString();

            Assert.Equal("You were not doing it", str);
        }

        [Fact]
        public void PastPerfect()
        {
            var sentence = SentenceFactory.CreateSentence("You do it");

            var str = sentence.Perfect().Past().Negative().ToString();

            Assert.Equal("You had not done it", str);
        }

        [Fact]
        public void PastPerfectProgressive()
        {
            var sentence = SentenceFactory.CreateSentence("You do it");

            var str = sentence.Progressive().Perfect().Past().Negative().ToString();

            Assert.Equal("You had not been doing it", str);
        }

        [Fact]
        public void SimplePassiveVoice()
        {
            var sentence = SentenceFactory.CreateSentence("I do by it");
            sentence.Passive();
            var str = sentence.Negative().ToString();
            Assert.Equal("I am not done by it", str);
        }

        [Fact]
        public void ProgressivePassiveVoice()
        {
            var sentence = SentenceFactory.CreateSentence("I do by it");
            sentence.Passive().Progressive();
            var str = sentence.Negative().ToString();
            Assert.Equal("I am not being done by it", str);
        }

        [Fact]
        public void PerfectPassiveVoice()
        {
            var sentence = SentenceFactory.CreateSentence("I do by it");
            sentence.Passive().Perfect();
            var str = sentence.Negative().ToString();
            Assert.Equal("I have not been done by it", str);
        }

        [Fact]
        public void PastSimplePassiveVoice()
        {
            var sentence = SentenceFactory.CreateSentence("I do by it");
            sentence.Passive().Past();
            var str = sentence.Negative().ToString();
            Assert.Equal("I was not done by it", str);
        }

        [Fact]
        public void PastProgressivePassiveVoice()
        {
            var sentence = SentenceFactory.CreateSentence("I do by it");
            sentence.Passive().Progressive().Past();
            var str = sentence.Negative().ToString();
            Assert.Equal("I was not being done by it", str);
        }

        [Fact]
        public void PastPerfectPassiveVoice()
        {
            var sentence = SentenceFactory.CreateSentence("I do by it");
            sentence.Passive().Perfect().Past();
            var str = sentence.Negative().ToString();
            Assert.Equal("I had not been done by it", str);
        }

        [Fact]
        public void FutureSimplePassiveVoice()
        {
            var sentence = SentenceFactory.CreateSentence("I do by it");
            sentence.Passive().Future();
            var str = sentence.Negative().ToString();
            Assert.Equal("I shall not be done by it", str);
        }

        [Fact]
        public void FuturePerfectPassiveVoice()
        {
            var sentence = SentenceFactory.CreateSentence("I do by it");
            sentence.Passive().Perfect().Future();
            var str = sentence.Negative().ToString();
            Assert.Equal("I shall not have been done by it", str);
        }

        [Fact]
        public void FutureInThePastSimplePassiveVoice()
        {
            var sentence = SentenceFactory.CreateSentence("I do by it");
            sentence.Passive().Future().Past();
            var str = sentence.Negative().ToString();
            Assert.Equal("I should not be done by it", str);
        }

        [Fact]
        public void FutureInThePastPerfectPassiveVoice()
        {
            var sentence = SentenceFactory.CreateSentence("I do by it");
            sentence.Passive().Perfect().Future().Past();
            var str = sentence.Negative().ToString();
            Assert.Equal("I should not have been done by it", str);
        }

        [Fact]
        public void FutureInThePastSimple()
        {
            var sentence = SentenceFactory.CreateSentence("I do it");
            sentence.Future().Past();
            var str = sentence.Negative().ToString();
            Assert.Equal("I should not do it", str);
        }

        [Fact]
        public void FutureInThePastProgressive()
        {
            var sentence = SentenceFactory.CreateSentence("I do it");
            sentence.Progressive().Future().Past();

            var str = sentence.Negative().ToString();

            Assert.Equal("I should not be doing it", str);
        }

        [Fact]
        public void FutureInThePastPerfect()
        {
            var sentence = SentenceFactory.CreateSentence("I do it");
            sentence.Perfect().Future().Past();

            var str = sentence.Negative().ToString();

            Assert.Equal("I should not have done it", str);
        }

        [Fact]
        public void FutureInThePastPerfectProgressive()
        {
            var sentence = SentenceFactory.CreateSentence("I do it");
            sentence.Progressive().Perfect().Future().Past();

            var str = sentence.Negative().ToString();

            Assert.Equal("I should not have been doing it", str);
        }
    }
}
