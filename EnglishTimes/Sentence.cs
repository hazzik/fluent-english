using System;
using System.Collections.Generic;
using System.Linq;

namespace Hazzik.FluentEnglishTimes
{
	public class Sentence : IPassive
	{
		private readonly IList<Word> _words;
		private SentenceState _state = SentenceState.None;

		public Sentence(IList<Word> words)
		{
			_words = words;
		}

		private Verb FirstVerb
		{
			get { return _words.OfType<Verb>().FirstOrDefault(); }
		}

		#region IPassive Members

		public IActive Passive()
		{
			_state |= SentenceState.Passive;

			FirstVerb.Form = VerbForms.V3;

			_words.Insert(1, Verb.Create("be"));

			return this;
		}

		public IPerfect Progressive()
		{
			_state |= SentenceState.Progressive;

			FirstVerb.Form = VerbForms.VIng;

			_words.Insert(1, Verb.Create("be"));

			return this;
		}

		public IFuture Perfect()
		{
			if ((_state & SentenceState.Passive) != 0 && (_state & SentenceState.Progressive) != 0)
			{
				throw new NotSupportedException();
			}

			_state |= SentenceState.Perfect;

			FirstVerb.Form = VerbForms.V3;

			_words.Insert(1, Verb.Create("have"));

			return this;
		}


		public IPast Future()
		{
			if ((_state & SentenceState.Passive) != 0 && (_state & SentenceState.Progressive) != 0)
			{
				throw new NotSupportedException();
			}

			_state |= SentenceState.Future;

			_words.Insert(1, Verb.Create("will"));

			return this;
		}

		public void Past()
		{
			_state |= SentenceState.Past;

			FirstVerb.Form = VerbForms.V2;

			return;
		}

		#endregion

		public override string ToString()
		{
			FirstVerb.PersonNumber = GetPersonNumber(_words.ToList()[0]);
			return string.Join(" ", _words.Select(w => w.ToString()).ToArray());
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