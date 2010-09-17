using System;

namespace Hazzik.FluentEnglishTimes.Verbs
{
	internal class ToHave : Verb
	{
		public ToHave() : base("have", "had", "had")
		{
		}

		public override string GetV1(SentenceState state)
		{
			return PersonNumber == VerbPersonNumber.ThirdSingular ? "has" : "have";
		}

		public override bool IsMatch(string verbString)
		{
			return verbString == "have" || verbString == "has" || verbString == "had" || verbString == "having";
		}

		protected override Verb Clone()
		{
			return new ToHave();
		}
	}
}