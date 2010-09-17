using System;

namespace Hazzik.FluentEnglishTimes.Verbs
{
	internal class Will : Verb
	{
		public Will() : base("will", "would", String.Empty)
		{
		}

		public override string GetV1(SentenceState state)
		{
			return PersonNumber == VerbPersonNumber.FirstSingular ? "shall" : "will";
		}

		public override string GetV2()
		{
			return PersonNumber == VerbPersonNumber.FirstSingular ? "should" : "would";
		}

		protected override Verb Clone()
		{
			return new Will();
		}
	}
}