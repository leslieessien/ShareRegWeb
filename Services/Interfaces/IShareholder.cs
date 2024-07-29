using ShareRegWeb.Models;

namespace ShareRegWeb.Services.Interfaces
{
    public interface IShareholder
    {
        public Task<bool> AddShareholder(ShareHolderDto shareHolder);

        public Task GetShareholder(string id);

        public Task GetAllShareholder();
    }
}