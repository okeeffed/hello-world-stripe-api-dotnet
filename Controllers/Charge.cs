  
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using ChargeApi.Models;

namespace dotnet_stripe.Controllers
{
    [ApiController]
    [Route("api/charges")]
    public class ChargesController : Controller
    {
        [HttpPost]
        public Stripe.Charge CreateCharge([FromBody] StripeCharge createOptions)
        {
            var options = new ChargeCreateOptions
            {
                Amount = createOptions.Amount,
                Currency = "usd",
                Source = "tok_visa",
                ReceiptEmail = "tim.apple@example.com",
            };
            var service = new ChargeService();
            var charge = service.Create(options);
            return charge;
        }
    }
}
