namespace UnityEngine.UI;

public struct SpriteState : IEquatable<SpriteState>
{
	[SerializeField]
	private Sprite m_HighlightedSprite; //Field offset: 0x0
	[SerializeField]
	private Sprite m_PressedSprite; //Field offset: 0x8
	[FormerlySerializedAs("m_HighlightedSprite")]
	[SerializeField]
	private Sprite m_SelectedSprite; //Field offset: 0x10
	[SerializeField]
	private Sprite m_DisabledSprite; //Field offset: 0x18

	public Sprite disabledSprite
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Sprite highlightedSprite
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public Sprite pressedSprite
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Sprite selectedSprite
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	public override bool Equals(SpriteState other) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public Sprite get_disabledSprite() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public Sprite get_highlightedSprite() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Sprite get_pressedSprite() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Sprite get_selectedSprite() { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_disabledSprite(Sprite value) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_highlightedSprite(Sprite value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_pressedSprite(Sprite value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_selectedSprite(Sprite value) { }

}

