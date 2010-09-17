namespace Hazzik.FluentEnglishTimes.Verbs
{
	internal class ToDo : Verb
	{
		public ToDo()
			: base("do", "did", "done")
		{
		}

		public override string V1
		{
			get
			{
				if (PersonNumber == VerbPersonNumber.ThirdSingular)
					return "does";
				return base.V1;
			}
		}

		protected override Verb Clone()
		{
			return new ToDo();
		}

		public override bool IsMatch(string verbString)
		{
			return "do" == verbString || "did" == verbString || "done" == verbString || verbString == "does";
		}
	}
}