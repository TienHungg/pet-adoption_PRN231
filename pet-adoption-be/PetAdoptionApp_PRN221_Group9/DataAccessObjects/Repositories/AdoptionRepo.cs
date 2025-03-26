using BusinessLogicLayer.IRepositories;
using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Org.BouncyCastle.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects.Repositories
{
    public class AdoptionRepo : GenericRepository<Adoption>, IAdoptionRepo
    {
        private readonly AppDBContext _dbContext;

        public AdoptionRepo(AppDBContext dBContext) : base(dBContext) 
        {
            _dbContext = dBContext;
        }

        public async Task<Adoption> GetAdoptionByPetId(Guid petId)
        {
            try
            {
                var result = await _dbContext.Adoptions.FirstOrDefaultAsync(x => x.PetId == petId);
                if (result == null)
                {
                    return new Adoption();
                }else
                {
                    return result;
                }


            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<Adoption>> GetAdoptionListByUser(Guid Id)
        {
            try
            {
                var result = await _dbContext.Adoptions
                    .Where(x => x.UserId == Id)
                    .Join(_dbContext.Pets,
                        adoption => adoption.PetId,
                        pet => pet.Id,
                        (adoption, pet) => new Adoption
                        {
                            Id = adoption.Id,
                            UserId = adoption.UserId,
                            PetId = pet.Id,
                            Pet = pet,
                            AdoptionStatus = adoption.AdoptionStatus,
                            ApplicationDate = adoption.ApplicationDate,
                            ApprovalDate = adoption.ApprovalDate,
                            AdoptionReason = adoption.AdoptionReason,
                            PetExperience = adoption.PetExperience,
                            Address = adoption.Address,
                            ContactNumber = adoption.ContactNumber,
                            Notes = adoption.Notes,
                            UserEmail = adoption.UserEmail
                        }).ToListAsync();
                if (result != null)
                { return result; }
                else { return Enumerable.Empty<Adoption>(); }



            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
