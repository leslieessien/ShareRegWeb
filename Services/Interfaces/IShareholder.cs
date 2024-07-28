namespace ShareRegWeb.Services.Interfaces
{
    public interface IShareholder
    {
        public Task AddShareholder(ShareHolderDto);

        public Task GetShareholder(string id);

        public Task GetAllShareholder();
    }