using Grpc.Core;
using GrpcDemo.Protos;

namespace GrpcDemo.Services;

public class CustomerService : Customer.CustomerBase
{
    public override Task<CustomerResponse> GetCustomerInformationInStringFormat(CustomerRequest request, ServerCallContext context)
    {
        return Task.FromResult(new CustomerResponse()
        {
            Information = "Hi " + request.Name + " " + request.Family + " your age is " +
                              request.Age + " and I LOVE YoU"
        });
    }

    public override async Task GetCustomers(GetCusmersRequest request, IServerStreamWriter<CusomerResponse> responseStream, ServerCallContext context)
    {
        List<CusomerResponse> customers = new()
        {
            new CusomerResponse(){Family = "amiri",Name = "mahdi"},
            new CusomerResponse(){Family = "Jabari",Name = "ali"},
            new CusomerResponse(){Family = "soheil",Name = "abbas"},
            new CusomerResponse(){Family = "ghanbari",Name = "jamal"}
        };

        foreach (var customer in customers)
        {
            await responseStream.WriteAsync(customer);
        }
    }
}