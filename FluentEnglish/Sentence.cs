using System;
using System.Collections.Generic;
using System.Linq;

namespace Hazzik.FluentEnglishTimes
{
	public class Sentence : IPassive
	{
		private readonly IList<Word> words;
		private SentenceState state = SentenceState.None;

		public Sentence(IList<Word> words)
		{
			this.words = words;
		}

		private Verb FirstVerb
		{
			get { return words.OfType<Verb>().FirstOrDefault(); }
		}

		#region IPassive Members

		public IActive Passive()
		{
			state |= SentenceState.Passive;

			FirstVerb.Form = VerbForms.V3;

			words.Insert(1, Verb.Create("be"));

			return this;
		}

		public IPerfect Progressive()
		{
			state |= SentenceState.Progressive;

			FirstVerb.Form = VerbForms.VIng;

			words.Insert(1, Verb.Create("be"));

			return this;
		}

		public IFuture Perfect()
		{
			if ((state & SentenceState.Passive) != 0 && (state & SentenceState.Progressive) != 0)
			{
				throw new NotSupportedException();
			}

			state |= SentenceState.Perfect;

			FirstVerb.Form = VerbForms.V3;

			words.Insert(1, Verb.Create("have"));

			return this;
		}


		public IPast Future()
		{
			if ((state & SentenceState.Passive) != 0 && (state & SentenceState.Progressive) != 0)
			{
				throw new NotSupportedException();
			}

			state |= SentenceState.Future;

		    string verbString = GetPersonNumber(words[0]) == VerbPersonNumber.FirstSingular
		                            ? "shall"
		                            : "will";

		    words.Insert(1, Verb.Create(verbString));

			return this;
		}

		public void Past()
		{
			state |= SentenceState.Past;

			FirstVerb.Form = VerbForms.V2;

			return;
		}

		#endregion

		public override string ToString()
		{
		    FirstVerb.PersonNumber = GetPersonNumber(words[0]);
			return string.Join(" ", words.Select(w => w.ToString()));
		}

		private static VerbPersonNumber GetPersonNumber(Word noun)
		{
			switch (noun.ToString())
			{
				case "I":
					{
						return VerbPersonNumber.FirstSingular;
					}
				case "You":
					{
						return VerbPersonNumber.Plural;
					}
				case "He":
				case "She":
				case "It":
					{
						return VerbPersonNumber.ThirdSingular;
					}
			}
			return VerbPersonNumber.Infinitive;
		}
	}
}