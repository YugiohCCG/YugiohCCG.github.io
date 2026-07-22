namespace UnityEngine.UI;

public class AnimationTriggers
{
	private const string kDefaultNormalAnimName = "Normal"; //Field offset: 0x0
	private const string kDefaultHighlightedAnimName = "Highlighted"; //Field offset: 0x0
	private const string kDefaultPressedAnimName = "Pressed"; //Field offset: 0x0
	private const string kDefaultSelectedAnimName = "Selected"; //Field offset: 0x0
	private const string kDefaultDisabledAnimName = "Disabled"; //Field offset: 0x0
	[FormerlySerializedAs("normalTrigger")]
	[SerializeField]
	private string m_NormalTrigger; //Field offset: 0x10
	[FormerlySerializedAs("highlightedTrigger")]
	[SerializeField]
	private string m_HighlightedTrigger; //Field offset: 0x18
	[FormerlySerializedAs("pressedTrigger")]
	[SerializeField]
	private string m_PressedTrigger; //Field offset: 0x20
	[FormerlySerializedAs("m_HighlightedTrigger")]
	[SerializeField]
	private string m_SelectedTrigger; //Field offset: 0x28
	[FormerlySerializedAs("disabledTrigger")]
	[SerializeField]
	private string m_DisabledTrigger; //Field offset: 0x30

	public string disabledTrigger
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string highlightedTrigger
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string normalTrigger
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string pressedTrigger
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public string selectedTrigger
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(Selectable), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public AnimationTriggers() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_disabledTrigger() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public string get_highlightedTrigger() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_normalTrigger() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_pressedTrigger() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_selectedTrigger() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_disabledTrigger(string value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_highlightedTrigger(string value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_normalTrigger(string value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_pressedTrigger(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_selectedTrigger(string value) { }

}

