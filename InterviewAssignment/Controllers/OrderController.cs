using InterviewAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InterviewAssignment.Controllers
{
    public class OrderController : Controller
    {
       private readonly AssignmentDbContext context;
        public OrderController(AssignmentDbContext _context)
        {
            this.context = _context;
        }
        public async Task<IActionResult> Index()
        {
            var orders = await context.table_order.ToListAsync();
            return View(orders);
        }
        public IActionResult Createuser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Createuser(Order tbl)
        {
            context.table_order.Add(tbl);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edituser(int id)
        {
            var data = context.table_order.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Edituser(Order tbl)
        {      
                context.Update(tbl);
                context.SaveChanges();
                return RedirectToAction("Index"); 
        }
        public async Task<IActionResult> Detailuser(int id)
        {
            var data = await context.table_order.FirstOrDefaultAsync(a=>a.Order_id==id);
            return View(data);
        }
        public async Task<IActionResult> Deleteuser(int id)
        {
            var data = await context.table_order.Include(a => a.orderdetail).FirstOrDefaultAsync(a => a.Order_id == id);
            return View(data);
        }
        [HttpPost,ActionName("Deleteuser")]
        public async Task<IActionResult> Deleteuser2(int id)
        {
            var data = await context.table_order.FindAsync(id);
            context.table_order.Remove(data);
            await context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Indexfruits()
        {
            var orders = await context.table_orderdetail.ToListAsync();
            return View(orders);
        }
        public IActionResult Createfruits()
        {
            List<Order> orders= context.table_order.ToList();
            ViewData["orderz"] = orders;
            return View();
        }
        [HttpPost]
        public IActionResult Createfruits(OrderDetail tbl)
        {    
            context.Add(tbl);
            context.SaveChanges();
            return RedirectToAction("indexfruits");
        }
        public IActionResult Editfruits(int id)
        {
            List<Order> orders = context.table_order.ToList();
            ViewData["orderz"] = orders;
            var data = context.table_orderdetail.Find(id);
            return View(data);
        }
        [HttpPost]
        public IActionResult Editfruits(OrderDetail tbl)
        {
            context.Update(tbl);
            context.SaveChanges();
            return RedirectToAction("indexfruits");
        }
        public async Task<IActionResult> Detailfruits(int id)
        {
            var data = await context.table_orderdetail.FirstOrDefaultAsync(a => a.OrderDetail_id == id);
            return View(data);
        }
        public async Task<IActionResult> Deletefruits(int id)
        {
            var data = await context.table_orderdetail.FirstOrDefaultAsync(a => a.OrderDetail_id == id);
            return View(data);
        }
        [HttpPost, ActionName("Deletefruits")]
        public async Task<IActionResult> Dltfruits(int id)
        {
            var data = await context.table_orderdetail.FindAsync(id);
            context.table_orderdetail.Remove(data);
            await context.SaveChangesAsync();
            return RedirectToAction("Indexfruits");
        }

    }
}
