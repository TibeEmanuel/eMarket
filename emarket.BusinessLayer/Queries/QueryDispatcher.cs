using eMarket.DataLayer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace eMarket.BusinessLayer.Queries
{
    public class QueryDispatcher : IQueryDispatcher
    {
        public QueryDispatcher(IRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }
        private IRepositoryFactory _repositoryFactory { get; set; }
        public TViewModel Execute<TViewModel>(Query query) where TViewModel : ViewModels.ViewModel
        {
            try
            {
                using (var scope = new TransactionScope())
                {
                    query.RepositoryFactory = _repositoryFactory;
                    var model = query.Execute();
                    scope.Complete();
                    return (TViewModel)model;

                }
            }
            catch (Exception ex)
            {
                var error = ex.InnerException; //send error to developer
                throw;
            }
        }
    }
}
