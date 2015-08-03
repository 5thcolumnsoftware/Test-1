using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Dresses4Heaven.Models;

namespace Dresses4Heaven.DAL
{

    //public class dressesDBInitializer : System.Data.Entity.DropCreateDatabaseAlways<DressesContext>
    public class dressesDBInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DressesContext>
    {
        protected override void Seed(DressesContext context)
        {
            var Customer = new List<Customer>
            {
            //,IntroDate=DateTime.Parse("2005-09-01")
            
            new Customer{FirstName="Carson",LastName="Alexander",PersAddress1="28 Temp Street",PersAddress2="Temp Area",PersAddress3="Temp Town",IntroDate=DateTime.Parse("2005-09-01")},
            new Customer{FirstName="Meredith",LastName="Alonso",PersAddress1="36Temp road",PersAddress2="Temp Area",PersAddress3="Temp Town",IntroDate=DateTime.Parse("2005-09-01")},
            new Customer{FirstName="Arturo",LastName="Anand",PersAddress1=" 42 Temp Avenue",PersAddress2="Temp Area",PersAddress3="Temp Town",IntroDate=DateTime.Parse("2005-09-01")},
            new Customer{FirstName="Gytis",LastName="Barzdukas",PersAddress1="85 Temp Lane",PersAddress2="Temp Area",PersAddress3="Temp Town",IntroDate=DateTime.Parse("2005-09-01")},
            new Customer{FirstName="Yan",LastName="Li",PersAddress1="23 Temp Close",PersAddress2="Temp Area",PersAddress3="Temp Town",IntroDate=DateTime.Parse("2005-09-01")},
            new Customer{FirstName="Peggy",LastName="Justice",PersAddress1=" 14 Temp Crescent",PersAddress2="Temp Area",PersAddress3="Temp Town",IntroDate=DateTime.Parse("2005-09-01")},
            new Customer{FirstName="Laura",LastName="Norman",PersAddress1="31 Temp Villas",PersAddress2="Temp Area",PersAddress3="Temp Town",IntroDate=DateTime.Parse("2005-09-01")},
            new Customer{FirstName="Nino",LastName="Olivetto",PersAddress1="2358 Temp Apartments",PersAddress2="Temp Area",PersAddress3="Temp Town 5",IntroDate=DateTime.Parse("2005-09-01")}
            };

            Customer.ForEach(s => context.Customer.Add(s));

            //context.SaveChanges();

            try
            {
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception exception = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);

                        //create a new exception inserting the current one
                        //as the InnerException
                        exception = new InvalidOperationException(message, exception);
                    }
                }
                throw exception;
            }

            
            var Events = new List<Event>
            {
            new Event{EventID=1050,Title="John's Christning",EventAddress1="jhg",EventAddress2="Temp Area",EventAddress3="Temp Town",EventDate=DateTime.Parse("2005-09-01")},
            new Event{EventID=4022,Title="Marie's Wedding",EventAddress1="kljh",EventAddress2="Temp Area",EventAddress3="Temp Town",EventDate=DateTime.Parse("2005-09-01")},
            new Event{EventID=4041,Title="Abigail's Birthday",EventAddress1="jhg",EventAddress2="Temp Area",EventAddress3="Temp Town",EventDate=DateTime.Parse("2005-09-01")},
            new Event{EventID=1045,Title="Colaiste Ita Debs",EventAddress1="twe",EventAddress2="Temp Area",EventAddress3="Temp Town",EventDate=DateTime.Parse("2005-09-01")},
            new Event{EventID=3141,Title="Sean's Wedding",EventAddress1="gfds",EventAddress2="Temp Area",EventAddress3="Temp Town",EventDate=DateTime.Parse("2005-09-01")},
            new Event{EventID=2021,Title="Colaiste Mhuire Debs",EventAddress1="mnv",EventAddress2="Temp Area",EventAddress3="Temp Town",EventDate=DateTime.Parse("2005-09-01")},
            new Event{EventID=2042,Title="Mary's Wedding",EventAddress1="bvc",EventAddress2="Temp Area",EventAddress3="Temp Town",EventDate=DateTime.Parse("2005-09-01")}
            };
            Events.ForEach(s => context.Events.Add(s));
            //context.SaveChanges();

            try
            {
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception exception = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);

                        //create a new exception inserting the current one
                        //as the InnerException
                        exception = new InvalidOperationException(message, exception);
                    }
                }
                throw exception;
            }
            

            var Orders = new List<Order>
            {
            new Order{CustomerID=1,EventID=1050,OrderType=OrderType.A,OrderDate=DateTime.Parse("2005-09-01"),DeadlineDate=DateTime.Parse("2016-09-01")},
            new Order{CustomerID=1,EventID=4022,OrderType=OrderType.C,OrderDate=DateTime.Parse("2005-09-01"),DeadlineDate=DateTime.Parse("2016-09-01")},
            new Order{CustomerID=1,EventID=4041,OrderType=OrderType.B,OrderDate=DateTime.Parse("2006-09-01"),DeadlineDate=DateTime.Parse("2016-09-01")},
            new Order{CustomerID=2,EventID=1045,OrderType=OrderType.B,OrderDate=DateTime.Parse("2010-07-01"),DeadlineDate=DateTime.Parse("2016-09-01")},
            new Order{CustomerID=2,EventID=3141,OrderType=OrderType.F,OrderDate=DateTime.Parse("2009-09-01"),DeadlineDate=DateTime.Parse("2016-09-01")},
            new Order{CustomerID=2,EventID=2021,OrderType=OrderType.F,OrderDate=DateTime.Parse("2008-09-01"),DeadlineDate=DateTime.Parse("2016-09-01")},
            new Order{CustomerID=3,EventID=1050,OrderDate=DateTime.Parse("2008-09-01"),DeadlineDate=DateTime.Parse("2016-09-01")},
            new Order{CustomerID=4,EventID=1050,OrderDate=DateTime.Parse("2008-09-01"),DeadlineDate=DateTime.Parse("2016-09-01")},
            new Order{CustomerID=4,EventID=4022,OrderType=OrderType.F,OrderDate=DateTime.Parse("2008-09-01"),DeadlineDate=DateTime.Parse("2016-09-01")},
            new Order{CustomerID=5,EventID=4041,OrderType=OrderType.C,OrderDate=DateTime.Parse("2008-09-01"),DeadlineDate=DateTime.Parse("2016-09-01")},
            new Order{CustomerID=6,EventID=1045,OrderDate=DateTime.Parse("2008-09-01"),DeadlineDate=DateTime.Parse("2016-09-01")},
            new Order{CustomerID=7,EventID=3141,OrderType=OrderType.A,OrderDate=DateTime.Parse("2008-09-01"),DeadlineDate=DateTime.Parse("2016-09-01")}
            };
            Orders.ForEach(s => context.Orders.Add(s));
            //context.SaveChanges();

            try
            {
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception exception = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);

                        //create a new exception inserting the current one
                        //as the InnerException
                        exception = new InvalidOperationException(message, exception);
                    }
                }
                throw exception;
            }
            
            
            var staffList = new List<Staff>
            {
                new Staff{ID=1001,FirstName="Justin",LastName="Time",HireDate=DateTime.Parse("2005-09-01"),PersAddress1="28 NewTemp Street",PersAddress2="Temp Area",PersAddress3="Temp Town",AccessLevel=AccessLevel.A},
                new Staff{ID=1001,FirstName="Michael",LastName="Quinn",HireDate=DateTime.Parse("2005-09-01"),PersAddress1="46 NewTemp Street",PersAddress2="Temp Area",PersAddress3="Temp Town",AccessLevel=AccessLevel.B}
            };
            staffList.ForEach(s => context.Staffs.Add(s));
            //context.SaveChanges();

            try
            {
                context.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception exception = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);

                        //create a new exception inserting the current one
                        //as the InnerException
                        exception = new InvalidOperationException(message, exception);
                    }
                }
                throw exception;
            }

        }
    }
}