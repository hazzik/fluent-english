namespace Hazzik.FluentEnglishTimes
{
	public class RegularVerb : Verb
	{
		public RegularVerb(string v1) : base(v1, v1 + "ed", v1 + "ed")
		{
		}
	}
}