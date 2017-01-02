namespace TeduShop.Data.Infrastructure
{
    public class DbFactory : Disposeable, IDbFactory
    {
        private TeduShopDbContext _dbContext;
        public TeduShopDbContext Init()
        {
            return _dbContext ?? (_dbContext = new TeduShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
            //_dbContext?.Dispose();

        }
    }
}
