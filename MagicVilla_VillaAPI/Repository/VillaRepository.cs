﻿using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db)
            : base(db)
        {
            _db = db;
        }

        public async Task<Villa> UpdateAsync(Villa entity)
        {
            var existingEntity = await _db.Villas
                .AsNoTracking()
                .FirstOrDefaultAsync(v => v.Id == entity.Id);
            if (existingEntity != null)
            {
                entity.CreatedDate = existingEntity.CreatedDate;
                entity.UpdatedDate = DateTime.UtcNow;
                _db.Villas.Update(entity);
                await _db.SaveChangesAsync();
            }
            return entity;
        }
    }
}
