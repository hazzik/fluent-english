using System;

namespace Hazzik.FluentEnglishTimes.Verbs
{
	internal class ToBe : Verb
	{
		public ToBe() : base(String.Empty, String.Empty, String.Empty)
		{
		}

		public override string V1
		{
			get
			{
				switch (PersonNumber)
				{
					case VerbPersonNumber.FirstSingular:
						return "am";
					case VerbPersonNumber.ThirdSingular:
						return "is";
					case VerbPersonNumber.Plural:
						return "are";
				}
				return base.V1;
			}
		}

		public override string V2
		{
			get { return PersonNumber == VerbPersonNumber.Plural ? "were" : "was"; }
		}

		public override string V3
		{
			get { return "been"; }
		}

		public override string VIng
		{
			get { return "being"; }
		}

		protected override Verb Clone()
		{
			return new ToBe();
		}

		public override bool IsMatch(string verbString)
		{
			return verbString == "be" || verbString == "am" || verbString == "are" || verbString == "is" || verbString == "was" ||
			       verbString == "were" || verbString == "been" || verbString == "being";
		}
	}
}