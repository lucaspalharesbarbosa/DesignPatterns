using System.Collections.Generic;

namespace Domain {
    public interface ICustomerRepository {
        IList<Customer> GetCustomers();
    }
}
