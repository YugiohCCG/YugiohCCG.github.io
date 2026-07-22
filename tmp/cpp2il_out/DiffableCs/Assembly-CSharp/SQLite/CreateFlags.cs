namespace SQLite;

[Flags]
public enum CreateFlags
{
	None = 0,
	ImplicitPK = 1,
	ImplicitIndex = 2,
	AllImplicit = 3,
	AutoIncPK = 4,
	FullTextSearch3 = 256,
	FullTextSearch4 = 512,
}

