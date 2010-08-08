﻿using System;
using System.Linq;

namespace Cosmos.Compiler.Assembler.X86
{
	/// <summary>
	/// Subtracts the source operand from the destination operand and 
	/// replaces the destination operand with the result. 
	/// </summary>
    [OpCode("sbb")]
	public class SubWithCarry : InstructionWithDestinationAndSourceAndSize
	{
}
}