using Domain;
using System.Collections.Generic;

namespace Repository {
    public class CustomerRepository : ICustomerRepository {
        public IList<Customer> GetCustomers() {
            // Simula operação no banco
            return new List<Customer>();
        }
    }
}
