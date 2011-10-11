using System;

namespace Hazzik.FluentEnglishTimes.Verbs
{
	internal class ToBe : Verb
	{
        public ToBe()
            : base("be", String.Empty, String.Empty)
        {
        }

	    public override string GetV1()
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
			return "be";
		}

		public override string GetV2()
		{
			return PersonNumber == VerbPersonNumber.Plural ? "were" : "was";
		}

		public override string GetV3()
		{
			return "been";
		}

		public override string GetVIng()
		{
			return "being";
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