namespace Hazzik.FluentEnglishTimes
{
	public class RegularVerb : Verb
	{
		public RegularVerb(string v1) : base(v1, CreateV2(v1), CreateV3(v1))
		{
		}

		private static string CreateV2(string v1)
		{
			if (v1.EndsWith("e"))
				return v1 + "d";
			return v1 + "ed";
		}

		private static string CreateV3(string v1)
		{
			if (v1.EndsWith("e"))
				return v1 + "d";
			return v1 + "ed";
		}
	}
}