using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ShareRegWeb.Data;
using ShareRegWeb.Models;
using ShareRegWeb.Services.Interfaces;

namespace ShareRegWeb.Services.Providers
{

    public class ShareholderService : IShareholder
    {
        private readonly ApplicationDbContext _dbContext;
        public ShareholderService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddShareholder(ShareHolderDto shareHolder)
        {
            var nameParam = new SqlParameter("@Name", shareHolder.Name);
            var genderParam = new SqlParameter("@Gender", shareHolder.Gender);
            var nationalityParam = new SqlParameter("@Nationality", shareHolder.Nationality);
            var emailParam = new SqlParameter("@Email", shareHolder.Email);
            var digitalAddressParam = new SqlParameter("@Address", shareHolder.Address);
            var phoneNumberParam = new SqlParameter("@PhoneNumber",shareHolder.PhoneNumber);
            var addressParam = new SqlParameter("@City", shareHolder.Address);
            var tinParam = new SqlParameter("@Tin", shareHolder.Tin);
            var idNoParam = new SqlParameter("@IdNumber", shareHolder.IdNumber);

            var results = await _dbContext.Database.ExecuteSqlRawAsync("EXEC spNewShareholderInsert @City,@PhoneNumber,@Address", idNoParam);
        }

        public Task GetAllShareholder()
        {
            throw new NotImplementedException();
        }

        public Task GetShareholder(string id)
        {
            throw new NotImplementedException();
        }
    }
}
