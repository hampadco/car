using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OmidApp.Models;
namespace OmidApp.Controllers;
[Authorize]
public class HomeController : Controller
{

   private readonly IUser dbuser;
    private readonly IWalet dbWalet;

    private readonly Context db;
    public HomeController(IUser _dbuser,IWalet _dbWalet,Context _db)
    {
       
        dbuser = _dbuser;
        dbWalet = _dbWalet;
        db = _db;
    }
    
 //test diff
  
    public async Task<IActionResult> home()
    {
      
     
      return View();
    }
  

    



   
    



  public IActionResult aboutus()
  {
    //TODO: Implement Realistic Implementation
    return View();
  }

  public IActionResult load()
  {
      // TODO: Your code here
      return View();
  }
  
  public IActionResult walet()
  {
    var id=User.Identity.GetId();
    var user=dbuser.ShowUser(Convert.ToInt32(id));
    if (user.Cart != "agent")
    {
      ViewBag.ListAgent=dbuser.ShowAllUseragent("");
    }
      return View();
  }


  public IActionResult ShowWalet()
  {
      // TODO: Your code here
      updateclaimAsync();
      var id=User.Identity.GetId();
      var user=dbuser.ShowUser(Convert.ToInt32(id));
      ViewBag.tel=user.Phone;
      ViewBag.ListWalet=dbWalet.ShowAllWalet(user.Phone);
      return View();
  }
  
  public IActionResult charge(string txt)
  {
      // TODO: Your code here
      // find phone user equal txt
     
      ViewBag.User=dbuser.ShowAllUser(txt);

      return View();
  }

  public IActionResult chargeuser(int id)
  {
      // TODO: Your code here
      
      var user=dbuser.ShowUser(id);
      ViewBag.User=user;
      //id add to session
      HttpContext.Session.SetString("id", id.ToString());

      return View();
  }

  public IActionResult chargeproccess(int txt)
  {
      // TODO: Your code here
      //get my phone
      var idme=User.Identity.GetId();
      var me=dbuser.ShowUser(Convert.ToInt32(idme));

      //get id from session
      var id=HttpContext.Session.GetString("id");
      var user=dbuser.ShowUser(Convert.ToInt32(id));
      //add walet
     var r= dbWalet.AddWalet(me,txt,user);
      if (r)
      {
       
        return RedirectToAction("ShowWalet","home");
      }
      else
      {
        TempData["msg"] = "موجودی ناکافی است";
        return RedirectToAction("chargeuser","home",new{id=id});
      }
      

      
  }
  
  public async Task updateclaimAsync()
  {
      // TODO: Your code here
       var id=User.Identity.GetId();
        var user=dbuser.ShowUser(Convert.ToInt32(id));
        
          var identity = (ClaimsIdentity)User.Identity;
          var claim = identity.FindFirst("cart");
          var claimwalet = identity.FindFirst("walet");

          if (claim.Value != "0")
          {
              identity.RemoveClaim(claim);
              identity.AddClaim(new Claim("cart", user.Cart));
          }
         

          if (claimwalet.Value != "0")
          {
              identity.RemoveClaim(claimwalet);
              identity.AddClaim(new Claim("walet", dbWalet.ShowMojodi(user.Phone).ToString()));
          }
          

   
              

          

          var principal = new ClaimsPrincipal(identity);
          await HttpContext.SignInAsync(principal);

}


public IActionResult send()
{
    // TODO: Your code here
    return View();
}


public IActionResult cat()
{
   //viewbag list category parentid =0 use  db
    ViewBag.ListCategory=db.Categories.Where(a=>a.ParentId==0).ToList();
    return View();
}

public IActionResult Car(int ParentId)
{
   //viewbag list category parentid =0 use  db
    ViewBag.ListCategory=db.Categories.Where(a=>a.ParentId==ParentId).ToList();
    return View();
}








}
