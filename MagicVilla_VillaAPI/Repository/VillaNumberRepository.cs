using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaNumberRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }

        public async Task<VillaNumber> UpdateAsync(VillaNumber entity)
        {
            var existingEntity = await _db.VillaNumbers
                .AsNoTracking()
                .FirstOrDefaultAsync(v => v.VillaNo == entity.VillaNo);
            if (existingEntity != null)
            {
                entity.CreatedDate = existingEntity.CreatedDate;
                entity.UpdatedDate = DateTime.Now;
                _db.VillaNumbers.Update(entity);
                await _db.SaveChangesAsync();
            }
            return entity;
        }
    }
}
