using System;
using CwLibNet.Enums;
using CwLibNet.IO;
using CwLibNet.Structs;
using CwLibNet.Types.Data;

namespace Cwlib.Structs
{
    public class SlotPhotoData : ISerializable
    {
        public const int BASE_ALLOCATION_SIZE = 0x10;

        public SlotID Id { get; set; }
        public ResourceDescriptor[] Photos { get; set; }

        public void Serialize(Serializer serializer)
        {
            Id = serializer.Struct(Id);
            int numPhotos = serializer.I32(Photos != null ? Photos.Length : 0);
            if (!serializer.IsWriting())
                Photos = new ResourceDescriptor[numPhotos];
            for (int i = 0; i < numPhotos; ++i)
                Photos[i] = serializer.Resource(Photos[i], ResourceType.Plan, true);
        }

        public int GetAllocatedSize()
        {
            int size = BASE_ALLOCATION_SIZE;
            if (Photos != null)
                size += (Photos.Length * 0x24);
            return size;
        }
    }
}