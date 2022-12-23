using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Index() //Index to client view
    {
      List<Client> model = _db.Clients //creates list of clients thats equal to the database results of Clients
                           .Include(client => client.Stylist)  //includes
                           .ToList();
      return View(model);
    }

    public ActionResult Create()  //?
    {
      ViewBag.StylistId = new SelectList(_db.Stylist, "StylistId", "Name");
      return View();
    }

    public ActionResult Create(Client client)
    {
      if (client.StylistId == 0) //checks if StylistId for the clients element is 0
      {
        return RedirectToAction("Create");  //Redirects to Create View if the StylistId is 0
      }
      _db.Clients.Add(client);   //Adds Stylist to client table within _db 
      _db.SaveChanges();  //saves changes to database
      return RedirectToAction("Index"); //redirects to Index
    }

    public ActionResult Details(int id)
    {
      Client thisClient = _db.Clients
                          .Include(client => client.ClientId)
                          .FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    public ActionResult Edit(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      ViewBag.StylistId = new SelectList(_db.Stylist, "StylistId", "Name");
      return View(thisClient);
    }

    [HttpPost]  //posting our client edit the database
    public ActionResult Edit(Client client) //takes in client object
    {
      _db.Clients.Update(client); //calles Clients table to Update the Client instance
      _db.SaveChanges();  //saves changes of the updated client instance above
      return RedirectToAction("Index"); //redirects to Index of Client View
    }

    public ActionResult Delete(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      return View(thisClient);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Client thisClient = _db.Clients.FirstOrDefault(client => client.ClientId == id);
      _db.Clients.Remove(thisClient);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


  }
}