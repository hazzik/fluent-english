using System;
using System.Collections.Generic;
using System.Linq;
using Hazzik.FluentEnglishTimes.Verbs;

namespace Hazzik.FluentEnglishTimes
{
	public class Verb : Word
	{
		private static readonly string[] Ends = new[] {"o", "j", "s", "x", "z", "ch", "sh", "zs"};

		private static readonly char[] Vowels = new[] {'a', 'e', 'i', 'o', 'u', 'y'};

		private static readonly IList<Verb> Verbs = InitVerbs();

		private readonly string v1;

		private readonly string v2;

		private readonly string v3;

		private readonly string vIng;

		private readonly string presentSimpleThirdSingular;

		protected Verb(string v1, string v2, string v3) : base(v1)
		{
			PersonNumber = VerbPersonNumber.Infinitive;
			Form = VerbForms.V1;
			this.v1 = v1;
			this.v2 = v2;
			this.v3 = v3;
			vIng = CreateVIngForm(v1);
			presentSimpleThirdSingular = CreatePresentSimpleThirdSingularForm(v1);
		}

		private static string CreateVIngForm(string v1)
		{
			if (v1.EndsWith("ie"))
			{
				return v1.Substring(0, v1.Length - 2) + "ying";
			}
			if (v1.EndsWith("e") && v1.EndsWith("ee") == false)
			{
				return v1.Substring(0, v1.Length - 1) + "ing";
			}
			return v1 + "ing";
		}

		public VerbForms Form { get; set; }

		public VerbPersonNumber PersonNumber { get; set; }

		public virtual string GetV1(SentenceState state)
		{
			if (state == SentenceState.None && PersonNumber == VerbPersonNumber.ThirdSingular)
			{
				return presentSimpleThirdSingular;
			}
			return v1;
		}

		private static string CreatePresentSimpleThirdSingularForm(string infinitive)
		{
			if (infinitive.EndsWith("y"))
			{
				var substring = infinitive.Substring(0, infinitive.Length - 1);
				var lastOrDefault = char.ToLower(substring.LastOrDefault());
				if (Vowels.Contains(lastOrDefault))
				{
					return infinitive + "s";
				}

				return substring + "ies";
			}

			if (Ends.Any(infinitive.EndsWith))
				return infinitive + "es";

			return infinitive + "s";
		}

		public virtual string GetV2()
		{
			return v2;
		}

		public virtual string GetV3()
		{
			return v3;
		}

		public virtual string GetVIng()
		{
			return vIng;
		}

		public override string ToString(SentenceState state)
		{
			switch (Form)
			{
				case VerbForms.V1:
					return GetV1(state);
				case VerbForms.V2:
					return GetV2();
				case VerbForms.V3:
					return GetV3();
				case VerbForms.VIng:
					return GetVIng();
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
			            		new ToDo()
			            	};
			return verbs;
		}

		public static Verb Create(string verbString)
		{
			Verb verb = (from v in Verbs
			             where v.IsMatch(verbString)
			             select v).FirstOrDefault() ?? new RegularVerb(verbString);
			return verb.Clone();
		}

		public virtual bool IsMatch(string verbString)
		{
			return GetV1(SentenceState.None) == verbString || GetV2() == verbString || GetV3() == verbString;
		}

		protected virtual Verb Clone()
		{
			return new Verb(GetV1(SentenceState.None), GetV2(), GetV3());
		}
	}
}