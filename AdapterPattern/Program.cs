using Repository;
using Service;

namespace AdapterPattern {
    class Program {
        static void Main(string[] args) {
            var customerRepository = new CustomerRepository();
            var cacheStorage = new HttpContextCacheStorageAdapter();
            var customerService = new CustomerService(customerRepository, cacheStorage);

            customerService.GetAllCustomers();
        }
    }
}
