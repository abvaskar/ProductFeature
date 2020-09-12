using BusinessRuleEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductFeature.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> productList = GetProductType();
            CustomerModel customer = GetCustomer();

            //foreach (IProductModel prod in cart)
            //{
            //    prod.ShipItem(customer);

            //    if (prod is IDigitalProductModel digital)
            //    {
            //        Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } downloads left.");
            //    }
            //}

            return View(productList);
        }

        [HttpPost]
        public ActionResult Index(string ddlCustomers)
        {
            List<SelectListItem> productList = GetProductType();
            if (!string.IsNullOrEmpty(ddlCustomers))
            {
                SelectListItem selectedItem = productList.Find(p => p.Value == ddlCustomers);
                string SelectedProd = getPaymentDetails(selectedItem.Text, selectedItem.Value);
                ViewBag.Message = "Product Name: " + selectedItem.Text;
                ViewBag.Message += "\\n Payment Details: " + SelectedProd;
            }
            return View(productList);
        }

        private static List<SelectListItem> GetProductType()
        {

            List<SelectListItem> customerList = new List<SelectListItem>();

            //Add Default Item at First Position.
            customerList.Insert(0, new SelectListItem { Text = "--Select Customer--", Value = "" });
            customerList.Insert(1, new SelectListItem { Text = "Physical Product", Value = "PhysicalProd" });
            customerList.Insert(2, new SelectListItem { Text = "Book Product", Value = "BookProd" });
            customerList.Insert(3, new SelectListItem { Text = "Register Membership", Value = "RegisterMember" });
            customerList.Insert(4, new SelectListItem { Text = "Upgrade Membership", Value = "UpgradeMember" });
            customerList.Insert(5, new SelectListItem { Text = "Video Product", Value = "VideoProd" });
            return customerList;
        }


        private static CustomerModel GetCustomer()
        {
            //can  add operation to register customer
            return new CustomerModel
            {
                FirstName = "Abhishek",
                LastName = "Vaskar",
                Email = "abhishek.vaskar@gmail.com"

            };
        }


        private static string getPaymentDetails(string selectedText, string SelectedValue)
        {
            List<IProductModel> output = AddSampleData();
            var ProductDetails = output.AsQueryable().FirstOrDefault(i => i.Title == selectedText);
            string selectedProd = string.Empty;

            selectedProd = ProductDetails.PaymentDetails(selectedText);


            return selectedProd;
        }

        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            output.Add(new PhysicalProductModel { Title = "Physical Product" });
            output.Add(new BookModel { Title = "Book Product" });
            output.Add(new MembershipModel { Title = "Register Membership" });
            output.Add(new MembershipModel { Title = "Upgrade Membership" });
            output.Add(new VideoModel { Title = "Video Product" });


            return output;
        }
    }
}