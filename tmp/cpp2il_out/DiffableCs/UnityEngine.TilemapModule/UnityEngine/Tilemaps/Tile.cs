namespace UnityEngine.Tilemaps;

[HelpURL("https://docs.unity3d.com/Manual/Tilemap-TileAsset.html")]
[RequiredByNativeCode]
public class Tile : TileBase
{
	internal enum ColliderType
	{
		None = 0,
		Sprite = 1,
		Grid = 2,
	}

	[SerializeField]
	private Sprite m_Sprite; //Field offset: 0x18
	[SerializeField]
	private Color m_Color; //Field offset: 0x20
	[SerializeField]
	private Matrix4x4 m_Transform; //Field offset: 0x30
	[SerializeField]
	private GameObject m_InstancedGameObject; //Field offset: 0x70
	[SerializeField]
	private TileFlags m_Flags; //Field offset: 0x78
	[SerializeField]
	private ColliderType m_ColliderType; //Field offset: 0x7C

	public ColliderType colliderType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Color color
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public TileFlags flags
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public GameObject gameObject
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Sprite sprite
	{
		[CallerCount(Count = 30)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public Matrix4x4 transform
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 35
		[CallerCount(Count = 0)]
		 set { } //Length: 32
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	public Tile() { }

	[CallerCount(Count = 0)]
	public ColliderType get_colliderType() { }

	[CallerCount(Count = 0)]
	public Color get_color() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public TileFlags get_flags() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GameObject get_gameObject() { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	public Sprite get_sprite() { }

	[CallerCount(Count = 0)]
	public Matrix4x4 get_transform() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public virtual void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_colliderType(ColliderType value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_color(Color value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_flags(TileFlags value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_gameObject(GameObject value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_sprite(Sprite value) { }

	[CallerCount(Count = 0)]
	public void set_transform(Matrix4x4 value) { }

}

