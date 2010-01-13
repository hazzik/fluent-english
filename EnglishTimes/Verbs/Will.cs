using System;

namespace Hazzik.FluentEnglishTimes.Verbs
{
	internal class Will : Verb
	{
		public Will() : base("will", "would", String.Empty)
		{
		}

		public override string V1
		{
			get { return PersonNumber == VerbPersonNumber.FirstSingular ? "shall" : base.V1; }
		}

		public override string V2
		{
			get { return PersonNumber == VerbPersonNumber.FirstSingular ? "should" : base.V2; }
		}

		protected override Verb Clone()
		{
			return new Will();
		}
	}
}