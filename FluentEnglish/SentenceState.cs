using System;

namespace Hazzik.FluentEnglishTimes
{
	[Flags]
	public enum SentenceState
	{
		None = 0,
		Passive = 1 << 0,
		Progressive = 1 << 1,
		Perfect = 1 << 2,
		Future = 1 << 3,
		Past = 1 << 4,
	}
}