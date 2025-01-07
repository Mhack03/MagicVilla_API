using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = [
                new VillaDTO{ Id= 1, Name= "Pool View", Occupancy =100, sqft=4 },
                new VillaDTO{ Id= 2, Name= "Beach View", Occupancy =300, sqft=3 }
                ];
    }
}
