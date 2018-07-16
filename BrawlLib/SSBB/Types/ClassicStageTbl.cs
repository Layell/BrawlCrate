using System;
using System.Runtime.InteropServices;

namespace BrawlLib.SSBB.Types
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ClassicStageBlock
    {
        public const int Size = 260;

        public ClassicStageBlockStageData _stages;
        public ClassicFighterData _opponent1;
        public ClassicFighterData _opponent2;
        public ClassicFighterData _opponent3;

        private VoidPtr Address { get { fixed (void* ptr = &this) return ptr; } }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ClassicStageBlockStageData
    {
        public const int Size = 20;

        public bint _unknown00;
        public bint _stageID1;
        public bint _stageID2;
        public bint _stageID3;
        public bint _stageID4;

        private VoidPtr Address { get { fixed (void* ptr = &this) return ptr; } }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ClassicFighterData
    {
        public const int Size = 0x50;

        public byte _fighterID;
        public byte _unknown01;
        public byte _unknown02;
        public byte _unknown03;
        public bfloat _unknown04;
        //public byte _unknown05;
        //public byte _unknown06;
        //public byte _unknown07;
        public byte _isAlly;
        public ClassicDifficultyData _difficulty1;
        public ClassicDifficultyData _difficulty2;
        public ClassicDifficultyData _difficulty3;
        public ClassicDifficultyData _difficulty4;
        public ClassicDifficultyData _difficulty5;
        public byte _padding4e;
        //public byte _padding4f;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct ClassicDifficultyData
    {
        public const int Size = 0x0E;

        public byte _unknown00;
        public byte _unknown01;
        public byte _unknown02;
        public byte _unknown03;
        public bshort _offenseRatio;
        public bshort _defenseRatio;
        public byte _unknown08;
        public byte _color;
        public byte _stock;
        public byte _unknown0b;
        public bshort _unknown0c;
    }
}