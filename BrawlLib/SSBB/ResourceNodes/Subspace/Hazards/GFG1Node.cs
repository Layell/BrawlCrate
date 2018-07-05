﻿using System;
using BrawlLib.SSBBTypes;
using System.ComponentModel;

namespace BrawlLib.SSBB.ResourceNodes
{
    public unsafe class GFG1Node : ResourceNode
    {
        internal GFG1* Header { get { return (GFG1*)WorkingUncompressed.Address; } }
        //public override ResourceType ResourceType { get { return ResourceType.GFG1; } }

        [Category("GFG1")]
        [DisplayName("Entries")]
        public int count { get { return Header->_count; } }
        public override void OnPopulate()
        {
            for (int i = 0; i < Header->_count; i++)
            {
                DataSource source;
                if (i == Header->_count - 1)
                { source = new DataSource((*Header)[i], WorkingUncompressed.Address + WorkingUncompressed.Length - (*Header)[i]); }
                else { source = new DataSource((*Header)[i], (*Header)[i + 1] - (*Header)[i]); }
                new GFG1EntryNode().Initialize(this, source);
            }
        }
        public override bool OnInitialize()
        {
            base.OnInitialize();
            if (_name == null)
                _name = "GFG1";
            return Header->_count > 0;
        }

        internal static ResourceNode TryParse(DataSource source) { return ((GFG1*)source.Address)->_tag == GFG1.Tag ? new GFG1Node() : null; }
    }

    public unsafe class GFG1EntryNode : ResourceNode
    {
        internal GFG1Entry* Header { get { return (GFG1Entry*)WorkingUncompressed.Address; } }
        //public override ResourceType ResourceType { get { return ResourceType.GFG1ENTRY; } }

        public byte _unknown0x01;
        public byte _unknown0x02;
        public byte _unknown0x03;
        public byte _unknown0x04;
        public byte _unknown0x05;
        public byte _unknown0x06;
        public byte _unknown0x07;
        public byte _unknown0x08;
        public byte _unknown0x09;
        public byte _unknown0x0A;
        public byte _unknown0x0B;
        public byte _unknown0x0C;
        public byte _unknown0x0D;
        public byte _unknown0x0E;
        public byte _unknown0x0F;
        public byte _unknown0x10;
        public byte _unknown0x11;
        public byte costumeID;      //0x12
        public byte _flag0x13;
        public byte _unknown0x14;
        public byte _unknown0x15;
        public byte _unknown0x16;
        public byte _unknown0x17;
        public byte _unknown0x18;
        public byte _unknown0x19;
        public byte _unknown0x1A;
        public byte _unknown0x1B;
        public byte _unknown0x1C;
        public byte _unknown0x1D;
        public byte _unknown0x1E;
        public byte _unknown0x1F;
        public byte _unknown0x20;
        public byte _unknown0x21;
        public byte _unknown0x22;
        public byte _unknown0x23;
        public bfloat _float0x24;
        public bfloat _float0x28;
        public bfloat scale;        // 0x2C
        public byte _unknown0x30;
        public byte _unknown0x31;
        public byte _unknown0x32;
        public byte _unknown0x33;
        public byte _unknown0x34;
        public byte _unknown0x35;
        public byte _unknown0x36;
        public byte _unknown0x37;
        public byte _unknown0x38;
        public byte _unknown0x39;
        public byte _unknown0x3A;
        public byte _unknown0x3B;
        public byte _unknown0x3C;
        public byte _unknown0x3D;
        public byte _unknown0x3E;
        public byte _unknown0x3F;
        public byte _unknown0x40;
        public byte _unknown0x41;
        public byte _unknown0x42;
        public byte _unknown0x43;
        public byte _unknown0x44;
        public byte _unknown0x45;
        public byte _unknown0x46;
        public byte _unknown0x47;
        public byte _unknown0x48;
        public byte _unknown0x49;
        public byte _unknown0x4A;
        public byte _unknown0x4B;
        public byte _unknown0x4C;
        public byte _unknown0x4D;
        public byte _unknown0x4E;
        public byte _unknown0x4F;
        public byte _unknown0x50;
        public byte _unknown0x51;
        public byte _unknown0x52;
        public byte _unknown0x53;

        public override bool OnInitialize()
        {
            base.OnInitialize();
            if (_name == null)
                _name = "Entry [" + Index + ']';
            return false;
        }
    }
}