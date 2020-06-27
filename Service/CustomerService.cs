using Domain;
using System.Collections.Generic;
using System.Web;

namespace Service
{
    public class CustomerService {
        private readonly ICustomerRepository _customerRepository;
        private readonly ICacheStorage _cacheStorage;

        public CustomerService(ICustomerRepository customerRepository, ICacheStorage cacheStorage) {
            _customerRepository = customerRepository;
            _cacheStorage = cacheStorage;
        }

        public IList<Customer> GetAllCustomers() {
            IList<Customer> customers;

            string storageKey = "GetAllCustomers";

            customers = (List<Customer>)HttpContext.Current.Cache.Get(storageKey);

            if (customers == null) {
                customers = _customerRepository.GetCustomers();

                _cacheStorage.Store(storageKey, customers);
            }

            return customers;
        }
    }
}
