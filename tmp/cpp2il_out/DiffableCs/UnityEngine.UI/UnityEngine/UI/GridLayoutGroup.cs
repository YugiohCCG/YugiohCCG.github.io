namespace UnityEngine.UI;

[AddComponentMenu("Layout/Grid Layout Group", 152)]
public class GridLayoutGroup : LayoutGroup
{
	internal enum Axis
	{
		Horizontal = 0,
		Vertical = 1,
	}

	internal enum Constraint
	{
		Flexible = 0,
		FixedColumnCount = 1,
		FixedRowCount = 2,
	}

	internal enum Corner
	{
		UpperLeft = 0,
		UpperRight = 1,
		LowerLeft = 2,
		LowerRight = 3,
	}

	[SerializeField]
	protected Corner m_StartCorner; //Field offset: 0x60
	[SerializeField]
	protected Axis m_StartAxis; //Field offset: 0x64
	[SerializeField]
	protected Vector2 m_CellSize; //Field offset: 0x68
	[SerializeField]
	protected Vector2 m_Spacing; //Field offset: 0x70
	[SerializeField]
	protected Constraint m_Constraint; //Field offset: 0x78
	[SerializeField]
	protected int m_ConstraintCount; //Field offset: 0x7C

	public Vector2 cellSize
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&), typeof(Vector2)}, ReturnType = typeof(void))]
		 set { } //Length: 81
	}

	public Constraint constraint
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
		 set { } //Length: 75
	}

	public int constraintCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CalledBy(Type = "Scenes.Battle.CardListDisplay", Member = "SetFrameSizing", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
		 set { } //Length: 85
	}

	public Vector2 spacing
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "CalculateMainDeckOverlap", ReturnType = typeof(void))]
		[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&), typeof(Vector2)}, ReturnType = typeof(void))]
		 set { } //Length: 81
	}

	public Axis startAxis
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
		 set { } //Length: 75
	}

	public Corner startCorner
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
		 set { } //Length: 75
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = ".ctor", ReturnType = typeof(void))]
	protected GridLayoutGroup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public virtual void CalculateLayoutInputHorizontal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	public virtual void CalculateLayoutInputVertical() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector2 get_cellSize() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Constraint get_constraint() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_constraintCount() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Vector2 get_spacing() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Axis get_startAxis() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public Corner get_startCorner() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&), typeof(Vector2)}, ReturnType = typeof(void))]
	public void set_cellSize(Vector2 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
	public void set_constraint(Constraint value) { }

	[CalledBy(Type = "Scenes.Battle.CardListDisplay", Member = "SetFrameSizing", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(int)}, ReturnType = typeof(void))]
	public void set_constraintCount(int value) { }

	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "CalculateMainDeckOverlap", ReturnType = typeof(void))]
	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2&), typeof(Vector2)}, ReturnType = typeof(void))]
	public void set_spacing(Vector2 value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
	public void set_startAxis(Axis value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LayoutGroup), Member = "SetProperty", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32Enum&), "System.Int32Enum"}, ReturnType = typeof(void))]
	public void set_startCorner(Corner value) { }

	[CalledBy(Type = typeof(GridLayoutGroup), Member = "SetLayoutHorizontal", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(GridLayoutGroup), Member = "SetLayoutVertical", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(LayoutGroup), Member = "get_rectTransform", ReturnType = typeof(RectTransform))]
	[Calls(Type = typeof(RectTransform), Member = "get_rect", ReturnType = typeof(Rect))]
	[Calls(Type = typeof(RectOffset), Member = "get_horizontal", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_vertical", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_left", ReturnType = typeof(int))]
	[Calls(Type = typeof(RectOffset), Member = "get_top", ReturnType = typeof(int))]
	[Calls(Type = typeof(LayoutGroup), Member = "SetChildAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMin", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_anchorMax", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RectTransform), Member = "set_sizeDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private void SetCellsAlongAxis(int axis) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public virtual void SetLayoutHorizontal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GridLayoutGroup), Member = "SetCellsAlongAxis", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public virtual void SetLayoutVertical() { }

}

