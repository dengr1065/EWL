using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EWLServer
{
    public static class PacketHelper
    {
        public static byte[] Wrap(byte cmd)
        {
            uint size = 1;
            byte[] packet = new byte[size + 4];
            byte[] bSize = BitConverter.GetBytes(size);
            bSize.CopyTo(packet, 0);
            packet[4] = cmd;
            return packet;
        }

        public static byte[] Wrap(byte cmd, byte[] data)
        {
            uint size = (uint)data.Length + 1;
            byte[] packet = new byte[size + 4];
            byte[] bSize = BitConverter.GetBytes(size);
            bSize.CopyTo(packet, 0);
            packet[4] = cmd;
            data.CopyTo(packet, 5);
            return packet;
        }

        public static byte[] Wrap(byte cmd, string str)
        {
            byte[] data = Encoding.UTF8.GetBytes(str);
            uint size = (uint)data.Length + 1;
            byte[] packet = new byte[size + 4];
            byte[] bSize = BitConverter.GetBytes(size);
            bSize.CopyTo(packet, 0);
            packet[4] = cmd;
            data.CopyTo(packet, 5);
            return packet;
        }

        public static byte[] Wrap(byte[] data)
        {
            uint size = (uint)data.Length;
            byte[] packet = new byte[size + 4];
            byte[] bSize = BitConverter.GetBytes(size);
            bSize.CopyTo(packet, 0);
            data.CopyTo(packet, 4);
            return packet;
        }
    }
}
