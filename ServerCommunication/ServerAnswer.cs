namespace ServerCommunication
{
	public class ServerAnswer
	{
		public ServerAnswer() : this(false, "Возникли проблемы с Json-преобразованием.") { }

		public ServerAnswer(bool successOfOperation, string causeOfProblems)
		{
			SuccessOfOperation = successOfOperation;
			CauseOfProblems = causeOfProblems;
		}

		public bool SuccessOfOperation
		{
			get; set;
		}

		public string CauseOfProblems
		{
			get; set;
		}
	}
}