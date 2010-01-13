using System;
using System.Collections.Generic;
using System.Linq;
using Hazzik.FluentEnglishTimes.Verbs;

namespace Hazzik.FluentEnglishTimes
{
	public class Verb : Word
	{
		private static readonly IList<Verb> _verbs = InitVerbs();

		protected Verb(string v1, string v2, string v3) : base(v1)
		{
			PersonNumber = VerbPersonNumber.Infinitive;
			Form = VerbForms.V1;
			V1 = v1;
			V2 = v2;
			V3 = v3;
			VIng = v1 + "ing";
		}

		public virtual string V1 { get; private set; }
		public virtual string V2 { get; private set; }
		public virtual string V3 { get; private set; }
		public virtual string VIng { get; private set; }

		public VerbForms Form { get; set; }

		public VerbPersonNumber PersonNumber { get; set; }

		public override string ToString()
		{
			switch (Form)
			{
				case VerbForms.V1:
					return V1;
				case VerbForms.V2:
					return V2;
				case VerbForms.V3:
					return V3;
				case VerbForms.VIng:
					return VIng;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

		private static IList<Verb> InitVerbs()
		{
			var verbs = new List<Verb>
			            	{
			            		new ToBe(),
			            		new ToHave(),
			            		new Will(),
			            		new Verb("do", "did", "done")
			            	};
			return verbs;
		}

		public static Verb Create(string verbString)
		{
			Verb verb = (from v in _verbs
			             where v.IsMatch(verbString)
			             select v).FirstOrDefault() ?? new RegularVerb(verbString);
			return verb.Clone();
		}

		public virtual bool IsMatch(string verbString)
		{
			return V1 == verbString || V2 == verbString || V3 == verbString;
		}

		protected virtual Verb Clone()
		{
			return new Verb(V1, V2, V3);
		}
	}
}