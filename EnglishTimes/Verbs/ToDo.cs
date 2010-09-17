using System.Linq;

namespace Hazzik.FluentEnglishTimes.Verbs
{
	internal class ToDo : Verb
	{
		private static readonly string[] Forms = new[] {"do", "does", "did", "done", "doing"};

		public ToDo()
			: base("do", "did", "done")
		{
		}

		protected override Verb Clone()
		{
			return new ToDo();
		}

		public override bool IsMatch(string verbString)
		{
			return Forms.Contains(verbString);
		}
	}
}