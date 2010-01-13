using System;

namespace Hazzik.FluentEnglishTimes.Verbs
{
	internal class ToHave : Verb
	{
		public ToHave() : base(String.Empty, String.Empty, String.Empty)
		{
		}

		public override string V1
		{
			get { return PersonNumber == VerbPersonNumber.ThirdSingular ? "has" : "have"; }
		}

		public override string V2
		{
			get { return "had"; }
		}

		public override string V3
		{
			get { return "had"; }
		}

		public override string VIng
		{
			get { return "having"; }
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