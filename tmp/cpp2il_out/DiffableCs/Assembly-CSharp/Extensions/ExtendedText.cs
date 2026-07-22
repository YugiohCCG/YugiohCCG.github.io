namespace Extensions;

public class ExtendedText : TextMeshProUGUI
{

	public int AutoSizeMaxIterationCount
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		 set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextMeshProUGUI), Member = ".ctor", ReturnType = typeof(void))]
	public ExtendedText() { }

	[CallerCount(Count = 0)]
	public int get_AutoSizeMaxIterationCount() { }

	[CallerCount(Count = 0)]
	public void set_AutoSizeMaxIterationCount(int value) { }

}

