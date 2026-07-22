namespace System.Security.Util;

internal sealed class TokenizerStringBlock
{
	internal String[] m_block; //Field offset: 0x10
	internal TokenizerStringBlock m_next; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public TokenizerStringBlock() { }

}

