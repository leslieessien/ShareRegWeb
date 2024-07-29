using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ShareRegWeb.Data;
using ShareRegWeb.Models;
using ShareRegWeb.Services.Interfaces;
using System.Net;

namespace ShareRegWeb.Services.Providers
{

    public class ShareholderService(ApplicationDbContext dbContext) : IShareholder
    {
        public async Task<bool> AddShareholder(ShareHolderDto shareHolder)
        {
            var nameParam = new SqlParameter("@Name", shareHolder.Name);
            var genderParam = new SqlParameter("@Gender", shareHolder.Gender);
            var nationalityParam = new SqlParameter("@Nationality", shareHolder.Nationality);
            var emailParam = new SqlParameter("@Email", shareHolder.Email);
            var digitalAddressParam = new SqlParameter("@DigitalAddress", shareHolder.Address);
            var phoneNumberParam = new SqlParameter("@PhoneNumber",shareHolder.PhoneNumber);
            var addressParam = new SqlParameter("@Address", shareHolder.Address);
            var tinParam = new SqlParameter("@Tin", shareHolder.Tin);
            var idNoParam = new SqlParameter("@IdNumber", shareHolder.IdNumber);
            var results = await dbContext.Database.ExecuteSqlRawAsync("EXEC spNewShareholderInsert @Name,@Gender,@Nationality,@Email,@DigitalAddress,@PhoneNumber,@Tin,@IdNumber",
                nameParam, genderParam, nationalityParam, emailParam, digitalAddressParam, phoneNumberParam, addressParam, tinParam, idNoParam, idNoParam);
            return results > 0;
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
