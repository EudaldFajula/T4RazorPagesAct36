using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T4Activitats.Act13;

namespace T4_RazorPages.Pages
{
    
    public class ViewSalesEmployeeModel : PageModel
    {
        public List<SalesEmployee> salesEmployees;
        public void OnGet()
        {
            salesEmployees = new List<SalesEmployee>
            {
				new SalesEmployee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(2116, 12, 12, 12, 12, 12), 564), 
                new SalesEmployee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(1111, 12, 12, 12, 12, 12), 564), 
                new SalesEmployee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(1114, 12, 12, 12, 12, 12), 564), 
                new SalesEmployee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(0573, 12, 12, 12, 12, 12), 564), 
                new SalesEmployee("Eudald", "Fajula", new DateTime(2006, 12, 12, 12, 12, 12), "0802", new DateTime(1765, 12, 12, 12, 12, 12), 564)
		};
        }
    }
}
