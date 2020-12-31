//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using global::System.Collections.Immutable;
using global::System.Linq;
using global::Bebop.Attributes;
using global::Bebop.Runtime;
//
// This source code was auto-generated by bebopc, Version=2.0.3.
//
namespace RainwayIPC.Models {
  [System.CodeDom.Compiler.GeneratedCode("bebopc", "2.0.3")]
  [BebopRecord]
  public enum PacketType : uint {
    TestMessage = 0,
    EntityPositionUpdate = 1
  }

  [System.CodeDom.Compiler.GeneratedCode("bebopc", "2.0.3")]
  [BebopRecord]
  public abstract class BaseTestMessageData : System.IEquatable<BaseTestMessageData> {
    [System.Diagnostics.CodeAnalysis.NotNull, System.Diagnostics.CodeAnalysis.DisallowNull]
    public string Msg { get; set; }

    public bool Equals(BaseTestMessageData other) {
      if (ReferenceEquals(null, other)) {
        return false;
      }
      if (ReferenceEquals(this, other)) {
        return true;
      }
      return Msg == other.Msg;
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) {
        return false;
      }
      if (ReferenceEquals(this, obj)) {
        return true;
      }
      if (obj is not BaseTestMessageData baseType) {
        return false;
      }
      return Equals(baseType);
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= Msg.GetHashCode();
      return hash;
    }

    public static bool operator ==(BaseTestMessageData left, BaseTestMessageData right) => Equals(left, right);
    public static bool operator !=(BaseTestMessageData left, BaseTestMessageData  right) => !Equals(left, right);

  }

  /// <inheritdoc />
  [System.CodeDom.Compiler.GeneratedCode("bebopc", "2.0.3")]
  [BebopRecord]
  public sealed class TestMessageData : BaseTestMessageData {
    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static byte[] Encode(BaseTestMessageData record) {
      var writer = BebopWriter.Create();
      EncodeInto(record, ref writer);
      return writer.ToArray();
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public byte[] Encode() {
      var writer = BebopWriter.Create();
      EncodeInto(this, ref writer);
      return writer.ToArray();
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static ImmutableArray<byte> EncodeAsImmutable(BaseTestMessageData record) {
      var writer = BebopWriter.Create();
      EncodeInto(record, ref writer);
      return writer.ToImmutableArray();
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public ImmutableArray<byte> EncodeAsImmutable() {
      var writer = BebopWriter.Create();
      EncodeInto(this, ref writer);
      return writer.ToImmutableArray();
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    internal static void EncodeInto(BaseTestMessageData record, ref BebopWriter writer) {
      writer.WriteString(record.Msg);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(byte[] record) where T : BaseTestMessageData, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static TestMessageData Decode(byte[] record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(System.ReadOnlySpan<byte> record) where T : BaseTestMessageData, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static TestMessageData Decode(System.ReadOnlySpan<byte> record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(System.ReadOnlyMemory<byte> record) where T : BaseTestMessageData, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static TestMessageData Decode(System.ReadOnlyMemory<byte> record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(System.ArraySegment<byte> record) where T : BaseTestMessageData, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static TestMessageData Decode(System.ArraySegment<byte> record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(ImmutableArray<byte> record) where T : BaseTestMessageData, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static TestMessageData Decode(ImmutableArray<byte> record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }


    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    internal static TestMessageData DecodeFrom(ref BebopReader reader) {

      string field0;
      field0 = reader.ReadString();
      return new TestMessageData {
        Msg = field0,
      };
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    internal static T DecodeFrom<T>(ref BebopReader reader) where T: BaseTestMessageData, new() {
      string field0;
      field0 = reader.ReadString();
      return new T {
        Msg = field0,
      };
    }
  }
  [System.CodeDom.Compiler.GeneratedCode("bebopc", "2.0.3")]
  [BebopRecord]
  public abstract class BaseEntityPositionData : System.IEquatable<BaseEntityPositionData> {
    [System.Diagnostics.CodeAnalysis.NotNull, System.Diagnostics.CodeAnalysis.DisallowNull]
    public double X { get; set; }
    [System.Diagnostics.CodeAnalysis.NotNull, System.Diagnostics.CodeAnalysis.DisallowNull]
    public double Y { get; set; }

    public bool Equals(BaseEntityPositionData other) {
      if (ReferenceEquals(null, other)) {
        return false;
      }
      if (ReferenceEquals(this, other)) {
        return true;
      }
      return X == other.X && Y == other.Y;
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) {
        return false;
      }
      if (ReferenceEquals(this, obj)) {
        return true;
      }
      if (obj is not BaseEntityPositionData baseType) {
        return false;
      }
      return Equals(baseType);
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= X.GetHashCode();
      hash ^= Y.GetHashCode();
      return hash;
    }

    public static bool operator ==(BaseEntityPositionData left, BaseEntityPositionData right) => Equals(left, right);
    public static bool operator !=(BaseEntityPositionData left, BaseEntityPositionData  right) => !Equals(left, right);

  }

  /// <inheritdoc />
  [System.CodeDom.Compiler.GeneratedCode("bebopc", "2.0.3")]
  [BebopRecord]
  public sealed class EntityPositionData : BaseEntityPositionData {
    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static byte[] Encode(BaseEntityPositionData record) {
      var writer = BebopWriter.Create();
      EncodeInto(record, ref writer);
      return writer.ToArray();
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public byte[] Encode() {
      var writer = BebopWriter.Create();
      EncodeInto(this, ref writer);
      return writer.ToArray();
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static ImmutableArray<byte> EncodeAsImmutable(BaseEntityPositionData record) {
      var writer = BebopWriter.Create();
      EncodeInto(record, ref writer);
      return writer.ToImmutableArray();
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public ImmutableArray<byte> EncodeAsImmutable() {
      var writer = BebopWriter.Create();
      EncodeInto(this, ref writer);
      return writer.ToImmutableArray();
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    internal static void EncodeInto(BaseEntityPositionData record, ref BebopWriter writer) {
      writer.WriteFloat64(record.X);
      writer.WriteFloat64(record.Y);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(byte[] record) where T : BaseEntityPositionData, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static EntityPositionData Decode(byte[] record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(System.ReadOnlySpan<byte> record) where T : BaseEntityPositionData, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static EntityPositionData Decode(System.ReadOnlySpan<byte> record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(System.ReadOnlyMemory<byte> record) where T : BaseEntityPositionData, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static EntityPositionData Decode(System.ReadOnlyMemory<byte> record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(System.ArraySegment<byte> record) where T : BaseEntityPositionData, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static EntityPositionData Decode(System.ArraySegment<byte> record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(ImmutableArray<byte> record) where T : BaseEntityPositionData, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static EntityPositionData Decode(ImmutableArray<byte> record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }


    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    internal static EntityPositionData DecodeFrom(ref BebopReader reader) {

      double field0;
      field0 = reader.ReadFloat64();
      double field1;
      field1 = reader.ReadFloat64();
      return new EntityPositionData {
        X = field0,
        Y = field1,
      };
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    internal static T DecodeFrom<T>(ref BebopReader reader) where T: BaseEntityPositionData, new() {
      double field0;
      field0 = reader.ReadFloat64();
      double field1;
      field1 = reader.ReadFloat64();
      return new T {
        X = field0,
        Y = field1,
      };
    }
  }
  [System.CodeDom.Compiler.GeneratedCode("bebopc", "2.0.3")]
  [BebopRecord]
  public abstract class BasePacket : System.IEquatable<BasePacket> {
    #nullable enable
    [System.Diagnostics.CodeAnalysis.MaybeNull, System.Diagnostics.CodeAnalysis.AllowNull]
    public PacketType? Type { get; set; }
    [System.Diagnostics.CodeAnalysis.MaybeNull, System.Diagnostics.CodeAnalysis.AllowNull]
    public BaseTestMessageData? TestMessageData { get; set; }
    [System.Diagnostics.CodeAnalysis.MaybeNull, System.Diagnostics.CodeAnalysis.AllowNull]
    public BaseEntityPositionData? EntityPositionData { get; set; }
    #nullable disable

    public bool Equals(BasePacket other) {
      if (ReferenceEquals(null, other)) {
        return false;
      }
      if (ReferenceEquals(this, other)) {
        return true;
      }
      return Type == other.Type && TestMessageData == other.TestMessageData && EntityPositionData == other.EntityPositionData;
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) {
        return false;
      }
      if (ReferenceEquals(this, obj)) {
        return true;
      }
      if (obj is not BasePacket baseType) {
        return false;
      }
      return Equals(baseType);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Type is not null) hash ^= Type.Value.GetHashCode();
      if (TestMessageData is not null) hash ^= TestMessageData.GetHashCode();
      if (EntityPositionData is not null) hash ^= EntityPositionData.GetHashCode();
      return hash;
    }

    public static bool operator ==(BasePacket left, BasePacket right) => Equals(left, right);
    public static bool operator !=(BasePacket left, BasePacket  right) => !Equals(left, right);

  }

  /// <inheritdoc />
  [System.CodeDom.Compiler.GeneratedCode("bebopc", "2.0.3")]
  [BebopRecord]
  public sealed class Packet : BasePacket {
    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static byte[] Encode(BasePacket record) {
      var writer = BebopWriter.Create();
      EncodeInto(record, ref writer);
      return writer.ToArray();
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public byte[] Encode() {
      var writer = BebopWriter.Create();
      EncodeInto(this, ref writer);
      return writer.ToArray();
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static ImmutableArray<byte> EncodeAsImmutable(BasePacket record) {
      var writer = BebopWriter.Create();
      EncodeInto(record, ref writer);
      return writer.ToImmutableArray();
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public ImmutableArray<byte> EncodeAsImmutable() {
      var writer = BebopWriter.Create();
      EncodeInto(this, ref writer);
      return writer.ToImmutableArray();
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    internal static void EncodeInto(BasePacket record, ref BebopWriter writer) {
      var pos = writer.ReserveRecordLength();
      var start = writer.Length;

      if (record.Type is not null) {
        writer.WriteByte(1);
        writer.WriteEnum<PacketType>(record.Type.Value);
      }

      if (record.TestMessageData is not null) {
        writer.WriteByte(2);
        RainwayIPC.Models.TestMessageData.EncodeInto(record.TestMessageData, ref writer);
      }

      if (record.EntityPositionData is not null) {
        writer.WriteByte(3);
        RainwayIPC.Models.EntityPositionData.EncodeInto(record.EntityPositionData, ref writer);
      }
      writer.WriteByte(0);
      var end = writer.Length;
      writer.FillRecordLength(pos, unchecked((uint) unchecked(end - start)));
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(byte[] record) where T : BasePacket, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static Packet Decode(byte[] record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(System.ReadOnlySpan<byte> record) where T : BasePacket, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static Packet Decode(System.ReadOnlySpan<byte> record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(System.ReadOnlyMemory<byte> record) where T : BasePacket, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static Packet Decode(System.ReadOnlyMemory<byte> record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(System.ArraySegment<byte> record) where T : BasePacket, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static Packet Decode(System.ArraySegment<byte> record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static T DecodeAs<T>(ImmutableArray<byte> record) where T : BasePacket, new() {
      var reader = BebopReader.From(record);
      return DecodeFrom<T>(ref reader);
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    public static Packet Decode(ImmutableArray<byte> record) {
      var reader = BebopReader.From(record);
      return DecodeFrom(ref reader);
    }


    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    internal static Packet DecodeFrom(ref BebopReader reader) {

      var record = new Packet();
      var length = reader.ReadRecordLength();
      var end = unchecked((int) (reader.Position + length));
      while (true) {
        switch (reader.ReadByte()) {
          case 0:
            return record;
          case 1:
            record.Type = reader.ReadEnum<PacketType>();
            break;
          case 2:
            record.TestMessageData = RainwayIPC.Models.TestMessageData.DecodeFrom(ref reader);
            break;
          case 3:
            record.EntityPositionData = RainwayIPC.Models.EntityPositionData.DecodeFrom(ref reader);
            break;
          default:
            reader.Position = end;
            return record;
        }
      }
    }

    [System.Runtime.CompilerServices.MethodImpl(BebopConstants.HotPath)]
    internal static T DecodeFrom<T>(ref BebopReader reader) where T: BasePacket, new() {
      var record = new T();
      var length = reader.ReadRecordLength();
      var end = unchecked((int) (reader.Position + length));
      while (true) {
        switch (reader.ReadByte()) {
          case 0:
            return record;
          case 1:
            record.Type = reader.ReadEnum<PacketType>();
            break;
          case 2:
            record.TestMessageData = RainwayIPC.Models.TestMessageData.DecodeFrom(ref reader);
            break;
          case 3:
            record.EntityPositionData = RainwayIPC.Models.EntityPositionData.DecodeFrom(ref reader);
            break;
          default:
            reader.Position = end;
            return record;
        }
      }
    }
  }
}
