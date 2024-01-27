using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SystemIO
{

    public class Reader : BaseIO {

        public Reader(string path) {

            br = new BinaryReader(File.OpenRead(path));
            this.byteorder = ByteOrder.BigEndian;

        }

        public Reader(string path, ByteOrder bo) {


            br = new BinaryReader(File.OpenRead(path));
            this.byteorder = bo;

        }
        
        BinaryReader br;

        public long Position
        {
            get { return br.BaseStream.Position; }
            set { br.BaseStream.Position = value; }
        }

        public byte ReadByte() {

            return br.ReadByte();
        }

        public sbyte ReadsByte() {

            return (sbyte)br.ReadByte();
        }

        //78 65
        public short Readint16() {

            short myshort = br.ReadInt16();//by default 65 78

            if (byteorder == ByteOrder.BigEndian) {

                byte[] buff = BitConverter.GetBytes(myshort);
                Array.Reverse(buff);//reverse the reading.
                myshort = BitConverter.ToInt16(buff, 0); //78 65

            }

            return myshort;
        }

        public ushort ReadUint16() {


            ushort myushort = br.ReadUInt16();//by default 65 78

            if (byteorder == ByteOrder.BigEndian)
            {

                byte[] buff = BitConverter.GetBytes(myushort);
                Array.Reverse(buff);//reverse the reading.
                myushort = BitConverter.ToUInt16(buff, 0); //78 65

            }
            return myushort;
        }

        public int Readint32()
        {
            int myInt32 = br.ReadInt32();//by default 65 78

            if (byteorder == ByteOrder.BigEndian)
            {

                byte[] buff = BitConverter.GetBytes(myInt32);
                Array.Reverse(buff);//reverse the reading.
                myInt32 = BitConverter.ToInt32(buff, 0); //78 65

            }
            return myInt32;
        }

        public uint ReadUint32()
        {
            uint myUInt32 = br.ReadUInt32();//by default 65 78

            if (byteorder == ByteOrder.BigEndian)
            {

                byte[] buff = BitConverter.GetBytes(myUInt32);
                Array.Reverse(buff);//reverse the reading.
                myUInt32 = BitConverter.ToUInt32(buff, 0); //78 65

            }
            return myUInt32;
        }


        public Int64 Readint64()
        {
            Int64 myint64 = br.ReadInt64();//by default 65 78

            if (byteorder == ByteOrder.BigEndian)
            {

                byte[] buff = BitConverter.GetBytes(myint64);
                Array.Reverse(buff);//reverse the reading.
                myint64 = BitConverter.ToInt64(buff, 0); //78 65

            }
            return myint64;
        }

        public UInt64 ReadUint64()
        {
            UInt64 myUint64 = br.ReadUInt64();//by default 65 78

            if (byteorder == ByteOrder.BigEndian)
            {

                byte[] buff = BitConverter.GetBytes(myUint64);
                Array.Reverse(buff);//reverse the reading.
                myUint64 = BitConverter.ToUInt64(buff, 0); //78 65

            }
            return myUint64;
        }

        public byte[] ReadByte(int amount) {


            byte[] buffer = br.ReadBytes(amount);

            if (byteorder == ByteOrder.LittleEndian) {

                Array.Reverse(buffer);
            }

            return buffer;
        }

        public void close() {


            br.Close();
        }

       

        public string ReadString(int length) {

           return new string (br.ReadChars(length));
        }

        public string ReadUnicodeString(int length) {

            if (byteorder == ByteOrder.BigEndian)
            {

                return Encoding.BigEndianUnicode.GetString(br.ReadBytes(length));

            }
            else {

                return Encoding.Unicode.GetString(br.ReadBytes(length));

            }
        }

        public char ReadChar()
        {

            return br.ReadChar();

        }

        public char[] ReadChars(int amount) {


            return br.ReadChars(amount);
        }

    }

    public class writter : BaseIO{

        BinaryWriter bw;


        public writter(string path) {

            bw = new BinaryWriter(File.OpenWrite(path));
            byteorder = ByteOrder.BigEndian;
            
        }

        public writter(string path,ByteOrder bo)
        {
            bw = new BinaryWriter(File.OpenWrite(path));
            byteorder = bo;
            
        }

        public long postio {

            get { return bw.BaseStream.Position; }
            set { bw.BaseStream.Position = value; }

        }

        public void writeByte(byte towrite) {

            bw.Write(towrite);
        }

        public void writebytes(byte[] bytesToWrite) {

            if (byteorder == ByteOrder.BigEndian)
            {

                Array.Reverse(bytesToWrite);
                bw.Write(bytesToWrite);
            }
            
        }

        public void writeInt16(short toWrite)
        {

            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteorder == ByteOrder.BigEndian) {

                Array.Reverse(buffer);
                bw.Write(buffer);
            }

        }


        public void writeUInt16(ushort toWrite)
        {

            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteorder == ByteOrder.BigEndian)
            {

                Array.Reverse(buffer);
                bw.Write(buffer);
            }

        }

        public void writeInt32(int toWrite)
        {

            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteorder == ByteOrder.BigEndian)
            {

                Array.Reverse(buffer);
                bw.Write(buffer);
            }

        }

        public void writeUInt32(UInt32 toWrite)
        {

            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteorder == ByteOrder.BigEndian)
            {

                Array.Reverse(buffer);
                bw.Write(buffer);
            }

        }

        public void writeInt64(Int64 toWrite)
        {

            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteorder == ByteOrder.BigEndian)
            {

                Array.Reverse(buffer);
                bw.Write(buffer);
            }

        }

        public void writeUInt64(UInt64 toWrite)
        {

            byte[] buffer = BitConverter.GetBytes(toWrite);
            if (byteorder == ByteOrder.BigEndian)
            {

                Array.Reverse(buffer);
                bw.Write(buffer);
            }

        }

        public void writeString(string stringTowrite) {

            bw.Write(stringTowrite.ToCharArray());
        }

        public void writeUnicode(string toWrite) {

            byte[] buffer = (byteorder == ByteOrder.BigEndian) ? Encoding.BigEndianUnicode.GetBytes(toWrite) : Encoding.Unicode.GetBytes(toWrite);
            bw.Write(buffer);
        }
 
        public void witeCharacter(char toWrite) {

            bw.Write(toWrite);
        }

        public void witeCharacters(char[] toWrite) {
            
            bw.Write(toWrite);
        }

        public void Close() {

            bw.Close();
        }
    }

    public abstract class BaseIO
    {

        public enum ByteOrder {

            BigEndian,
            LittleEndian
        }

        protected ByteOrder byteorder;

        public void ChangeByteOrder(ByteOrder bo)
        {

            this.byteorder = bo;
        }
    }
}
