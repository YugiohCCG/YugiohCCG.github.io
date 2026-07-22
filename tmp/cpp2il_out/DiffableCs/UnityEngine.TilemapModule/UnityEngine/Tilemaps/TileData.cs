namespace UnityEngine.Tilemaps;

[NativeType(Header = "Modules/Tilemap/TilemapScripting.h")]
[RequiredByNativeCode]
public struct TileData
{
	internal static readonly TileData Default; //Field offset: 0x0
	private int m_Sprite; //Field offset: 0x0
	private Color m_Color; //Field offset: 0x4
	private Matrix4x4 m_Transform; //Field offset: 0x14
	private int m_GameObject; //Field offset: 0x54
	private TileFlags m_Flags; //Field offset: 0x58
	private ColliderType m_ColliderType; //Field offset: 0x5C

	public ColliderType colliderType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public Color color
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public TileFlags flags
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public GameObject gameObject
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 132
	}

	public Sprite sprite
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 130
	}

	public Matrix4x4 transform
	{
		[CallerCount(Count = 0)]
		 set { } //Length: 32
	}

	[CallerCount(Count = 0)]
	private static TileData() { }

	[CallerCount(Count = 0)]
	private static TileData CreateDefault() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_colliderType(ColliderType value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_color(Color value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_flags(TileFlags value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public void set_gameObject(GameObject value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public void set_sprite(Sprite value) { }

	[CallerCount(Count = 0)]
	public void set_transform(Matrix4x4 value) { }

}

