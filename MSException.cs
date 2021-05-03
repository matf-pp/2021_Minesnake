using System;

namespace MineSnake { 

	[Serializable]
	public class MSException : Exception
	{
		public MSException() { }

		public MSException(string message)
			: base(message) { }

		public MSException(string message, Exception inner)
			: base(message, inner) { }
	}
}
