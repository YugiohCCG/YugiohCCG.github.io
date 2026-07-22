namespace ClientAPI;

public class Cards
{
	[CompilerGenerated]
	private int <id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private byte <ot>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <alias>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Byte[] <setcode>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <type>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <level>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private int <race>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private byte <attribute>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private int <atk>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private int <def>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private int <category>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Byte[] <script>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private long <genre>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Byte[] <support>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private int <rule_code>k__BackingField; //Field offset: 0x60

	[Column("alias")]
	public int alias
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[Column("atk")]
	public int atk
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[Column("attribute")]
	public byte attribute
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[Column("category")]
	public int category
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[Column("def")]
	public int def
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[Column("genre")]
	public long genre
	{
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	[Column("id")]
	[PrimaryKey]
	public int id
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[Column("level")]
	public int level
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[Column("ot")]
	public byte ot
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[Column("race")]
	public int race
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[Column("rule_code")]
	public int rule_code
	{
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 16)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[Column("script")]
	public Byte[] script
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 254
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[Column("setcode")]
	public Byte[] setcode
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[Column("support")]
	public Byte[] support
	{
		[CallerCount(Count = 10)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[Column("type")]
	public int type
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Cards() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_alias() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_atk() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public byte get_attribute() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_category() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_def() { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public long get_genre() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_id() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_level() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public byte get_ot() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_race() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_rule_code() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Byte[] get_script() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Byte[] get_setcode() { }

	[CallerCount(Count = 10)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Byte[] get_support() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_type() { }

	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_alias(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_atk(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_attribute(byte value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_category(int value) { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_def(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_genre(long value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_id(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_level(int value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_ot(byte value) { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_race(int value) { }

	[CallerCount(Count = 16)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_rule_code(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_script(Byte[] value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_setcode(Byte[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_support(Byte[] value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_type(int value) { }

}

